using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Config
{
    public class MedSystemContext : IdentityDbContext<User>
    {
        private readonly IConfiguration _configuration;
        
        #region  Dbset
        public virtual DbSet<Disease> Diseases { get; set; }

        public virtual DbSet<DiseaseSymptoms> DiseaseSymptoms { get; set; }

        public virtual DbSet<Doctor> Doctors { get; set; }

        public virtual DbSet<Feedback> Feedbacks { get; set; }  

        public virtual DbSet<FeesDoctor> FeesDoctors { get; set; }

        public virtual DbSet<Medicine> Medicines { get; set; }

        public virtual DbSet<MedicineProvider> MedicineProviders { get; set; }

        public virtual DbSet<News> News { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderDetails> OrderDetails { get; set; }

        public virtual DbSet<Patient> Patients { get; set; }

        public virtual DbSet<PatientBooking> PatientBookings { get; set; }
        
        public virtual DbSet<Payment> Payments { get; set; }

        public virtual DbSet<Prescription> Prescriptions { get; set; }

        public virtual DbSet<PrescriptionDetail> PrescriptionsDetail { get; set; }

        public virtual DbSet<ScheduleDate> ScheduleDates { get; set; }   

        public virtual DbSet<ScheduleDoctor> ScheduleDoctors { get; set; }

        public virtual DbSet<Shift> Shifts { get; set; }

        public virtual DbSet<Symptoms> Symptomses { get; set; }





        #endregion
        public MedSystemContext(DbContextOptions<MedSystemContext> options, IConfiguration configuration):base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MyDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Disease>(entity =>
            {
                entity.Property(e => e.Id)
                    .IsRequired()
                    .UseIdentityColumn(1);
                entity.HasMany(e => e.Medicines)
                    .WithMany(e => e.Diseases)
                    .UsingEntity(
                    "DiseaseMedicine",
                    l => l.HasOne(typeof(Disease)).WithMany().HasForeignKey("DiseasesId").OnDelete(DeleteBehavior.NoAction),
                    r => r.HasOne(typeof(Medicine)).WithMany().HasForeignKey("MedicinesId").OnDelete(DeleteBehavior.NoAction),
                    j => j.HasKey("DiseasesId", "MedicinesId")
                    );
                entity.HasMany(e => e.Symptoms)
                    .WithMany(e => e.Diseases)
                    .UsingEntity<DiseaseSymptoms>();
                   
            });
            builder.Entity<Medicine>(entity =>
            {
                entity.Property(e => e.Id)
                .UseIdentityColumn(1);
                entity.HasOne(e => e.MedicineProvider)
                    .WithMany(e => e.Medicines)
                    .HasForeignKey(e => e.ProviderId);
            });
            builder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.UserId);
                entity.HasOne(e => e.User)
                    .WithOne(e => e.Doctor)
                    .HasForeignKey<Doctor>(e => e.UserId)
                    .IsRequired(true);

                entity.HasMany(e => e.FeesDoctors)
                    .WithOne(e => e.Doctor)
                    .HasForeignKey(e => e.DoctorId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.HasMany(e => e.ScheduleDoctors)
                      .WithOne(e => e.Doctor)
                      .HasForeignKey(e =>e.DoctorId);
            });

            builder.Entity<MedicineProvider>(entity =>
            {
                entity.HasKey(e => e.UserId);
                entity.HasOne(e => e.User)
                       .WithOne(e => e.MedicineProvider)
                       .HasForeignKey<MedicineProvider>(e => e.UserId);
            });
            builder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.UserId);
                entity.HasOne(e => e.User)
                    .WithOne(e => e.Patient)
                    .HasForeignKey<Patient>(e => e.UserId);
                entity.HasMany(e => e.FeesDoctors)
                      .WithOne(e => e.Patient)
                      .HasForeignKey(e => e.PatientId)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            builder.Entity<Prescription>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.Doctor)
                       .WithMany(e => e.Prescriptions)
                       .HasForeignKey(e => e.DoctorId)
                       .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(e => e.Patient)
                       .WithMany(e => e.Prescriptions)
                       .HasForeignKey(e => e.PatientId)
                       .OnDelete(DeleteBehavior.NoAction);               
            });
            builder.Entity<PatientBooking>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.Patient)
                       .WithMany(e => e.PatientBookings)
                       .HasForeignKey(e => e.PatientId)
                       .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(e => e.Doctor)
                      .WithMany(e => e.PatientBookings)
                      .HasForeignKey(e => e.DoctorId)
                      .OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(e => e.Schedule)
                    .WithOne()
                    .HasForeignKey<PatientBooking>(e => e.ScheduleDoctorId)
                    .OnDelete(DeleteBehavior.NoAction);
            });
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = Constants.UserRole.PATIENT,NormalizedName = Constants.UserRole.PATIENT},
                new IdentityRole { Id = "2", Name = Constants.UserRole.DOCTOR,NormalizedName = Constants.UserRole.DOCTOR},
                new IdentityRole { Id = "3", Name = Constants.UserRole.CAREGIVER,NormalizedName = Constants.UserRole.CAREGIVER}
                );
            builder.Entity<User>(e =>
            {
                var hasher = new PasswordHasher<User>();
                var user1 = new User
                {
                    Id = "1",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    NormalizedEmail = "admin@email.com",
                    Email = "admin@email.com",
                    EmailConfirmed = true
                };
                var user2 = new User
                {
                    Id = "2",
                    UserName = "account1",
                    NormalizedUserName = "ACCOUNT1",
                    NormalizedEmail = "account1@email.com",
                    Email = "account1@email.com",
                    EmailConfirmed = true
                };
                var user3 = new User
                {
                    Id = "3",
                    UserName = "account2",
                    NormalizedUserName = "ACCOUNT2",
                    NormalizedEmail = "account2@email.com",
                    Email = "account2@email.com",
                    EmailConfirmed = true
                };
                user1.PasswordHash = hasher.HashPassword(user1, "Password123@");
                user2.PasswordHash = hasher.HashPassword(user2, "Password123@");
                user3.PasswordHash = hasher.HashPassword(user3, "Password123@");
                e.HasData(user1);
                e.HasData(user2);
                e.HasData(user3);

            });
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = "1", UserId = "1" },
                new IdentityUserRole<string> { RoleId = "1", UserId = "2" },
                new IdentityUserRole<string> { RoleId = "1", UserId = "3" }
                );
            
        }
    }
}
