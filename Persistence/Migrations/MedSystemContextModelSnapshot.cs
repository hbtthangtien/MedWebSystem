﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Config;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(MedSystemContext))]
    partial class MedSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiseaseMedicine", b =>
                {
                    b.Property<int>("DiseasesId")
                        .HasColumnType("int");

                    b.Property<int>("MedicinesId")
                        .HasColumnType("int");

                    b.HasKey("DiseasesId", "MedicinesId");

                    b.HasIndex("MedicinesId");

                    b.ToTable("DiseaseMedicine");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Persistence.Entities.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Treatements")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("Persistence.Entities.DiseaseSymptoms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DiseaseId")
                        .HasColumnType("int");

                    b.Property<int>("SymptomsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiseaseId");

                    b.HasIndex("SymptomsId");

                    b.ToTable("DiseaseSymptoms");
                });

            modelBuilder.Entity("Persistence.Entities.Doctor", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Hospital")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LisenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfExperiences")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Persistence.Entities.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PatientUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorUserId");

                    b.HasIndex("PatientUserId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Persistence.Entities.FeesDoctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<string>("DoctorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("Duration")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("FeesDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PatientBookingId")
                        .HasColumnType("int");

                    b.Property<string>("PatientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientBookingId");

                    b.HasIndex("PatientId");

                    b.ToTable("FeesDoctors");
                });

            modelBuilder.Entity("Persistence.Entities.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProviderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("Persistence.Entities.MedicineProvider", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("MedicineProviders");
                });

            modelBuilder.Entity("Persistence.Entities.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Headline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Persistence.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateOrder")
                        .HasColumnType("datetime2");

                    b.Property<string>("MedicineProviderUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PatientUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("StatusOrder")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("providerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MedicineProviderUserId");

                    b.HasIndex("PatientUserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Persistence.Entities.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicineId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Persistence.Entities.Patient", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Persistence.Entities.PatientBooking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DoctorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PatientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ScheduleDoctorId")
                        .HasColumnType("int");

                    b.Property<int>("StatusBooking")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("ScheduleDoctorId")
                        .IsUnique();

                    b.ToTable("PatientBookings");
                });

            modelBuilder.Entity("Persistence.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FeesDoctorId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PatientUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PaymentCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int>("StatusPayment")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FeesDoctorId");

                    b.HasIndex("OrderId");

                    b.HasIndex("PatientUserId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Persistence.Entities.Prescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateIssue")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PatientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("Persistence.Entities.PrescriptionDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Dossage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicineId");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("PrescriptionsDetail");
                });

            modelBuilder.Entity("Persistence.Entities.ScheduleDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("ScheduleDates");
                });

            modelBuilder.Entity("Persistence.Entities.ScheduleDoctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DoctorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ScheduleDateId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleStatus")
                        .HasColumnType("int");

                    b.Property<int>("ShiftId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("ScheduleDateId");

                    b.HasIndex("ShiftId");

                    b.ToTable("ScheduleDoctors");
                });

            modelBuilder.Entity("Persistence.Entities.Shift", b =>
                {
                    b.Property<int>("ShiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShiftId"));

                    b.Property<string>("ScheduleTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShiftId");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("Persistence.Entities.Symptoms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descriptions")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Symptomses");
                });

            modelBuilder.Entity("Persistence.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("DiseaseMedicine", b =>
                {
                    b.HasOne("Persistence.Entities.Disease", null)
                        .WithMany()
                        .HasForeignKey("DiseasesId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Persistence.Entities.Medicine", null)
                        .WithMany()
                        .HasForeignKey("MedicinesId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Persistence.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Persistence.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Persistence.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Persistence.Entities.DiseaseSymptoms", b =>
                {
                    b.HasOne("Persistence.Entities.Disease", "Disease")
                        .WithMany()
                        .HasForeignKey("DiseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.Entities.Symptoms", "Symptoms")
                        .WithMany()
                        .HasForeignKey("SymptomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disease");

                    b.Navigation("Symptoms");
                });

            modelBuilder.Entity("Persistence.Entities.Doctor", b =>
                {
                    b.HasOne("Persistence.Entities.User", "User")
                        .WithOne("Doctor")
                        .HasForeignKey("Persistence.Entities.Doctor", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Persistence.Entities.Feedback", b =>
                {
                    b.HasOne("Persistence.Entities.Doctor", null)
                        .WithMany("Feedbacks")
                        .HasForeignKey("DoctorUserId");

                    b.HasOne("Persistence.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientUserId");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Persistence.Entities.FeesDoctor", b =>
                {
                    b.HasOne("Persistence.Entities.Doctor", "Doctor")
                        .WithMany("FeesDoctors")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Persistence.Entities.PatientBooking", "PatientBooking")
                        .WithMany()
                        .HasForeignKey("PatientBookingId");

                    b.HasOne("Persistence.Entities.Patient", "Patient")
                        .WithMany("FeesDoctors")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("PatientBooking");
                });

            modelBuilder.Entity("Persistence.Entities.Medicine", b =>
                {
                    b.HasOne("Persistence.Entities.MedicineProvider", "MedicineProvider")
                        .WithMany("Medicines")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicineProvider");
                });

            modelBuilder.Entity("Persistence.Entities.MedicineProvider", b =>
                {
                    b.HasOne("Persistence.Entities.User", "User")
                        .WithOne("MedicineProvider")
                        .HasForeignKey("Persistence.Entities.MedicineProvider", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Persistence.Entities.Order", b =>
                {
                    b.HasOne("Persistence.Entities.MedicineProvider", "MedicineProvider")
                        .WithMany()
                        .HasForeignKey("MedicineProviderUserId");

                    b.HasOne("Persistence.Entities.Patient", "Patient")
                        .WithMany("Orders")
                        .HasForeignKey("PatientUserId");

                    b.Navigation("MedicineProvider");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Persistence.Entities.OrderDetails", b =>
                {
                    b.HasOne("Persistence.Entities.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Persistence.Entities.Patient", b =>
                {
                    b.HasOne("Persistence.Entities.User", "User")
                        .WithOne("Patient")
                        .HasForeignKey("Persistence.Entities.Patient", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Persistence.Entities.PatientBooking", b =>
                {
                    b.HasOne("Persistence.Entities.Doctor", "Doctor")
                        .WithMany("PatientBookings")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Persistence.Entities.Patient", "Patient")
                        .WithMany("PatientBookings")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Persistence.Entities.ScheduleDoctor", "Schedule")
                        .WithOne()
                        .HasForeignKey("Persistence.Entities.PatientBooking", "ScheduleDoctorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("Persistence.Entities.Payment", b =>
                {
                    b.HasOne("Persistence.Entities.FeesDoctor", "FeesDoctor")
                        .WithMany()
                        .HasForeignKey("FeesDoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.Entities.Patient", "Patient")
                        .WithMany("Payments")
                        .HasForeignKey("PatientUserId");

                    b.Navigation("FeesDoctor");

                    b.Navigation("Order");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Persistence.Entities.Prescription", b =>
                {
                    b.HasOne("Persistence.Entities.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Persistence.Entities.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Persistence.Entities.PrescriptionDetail", b =>
                {
                    b.HasOne("Persistence.Entities.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.Entities.Prescription", "Prescription")
                        .WithMany("Details")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("Persistence.Entities.ScheduleDoctor", b =>
                {
                    b.HasOne("Persistence.Entities.Doctor", "Doctor")
                        .WithMany("ScheduleDoctors")
                        .HasForeignKey("DoctorId");

                    b.HasOne("Persistence.Entities.ScheduleDate", "ScheduleDate")
                        .WithMany()
                        .HasForeignKey("ScheduleDateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Persistence.Entities.Shift", "Shift")
                        .WithMany()
                        .HasForeignKey("ShiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("ScheduleDate");

                    b.Navigation("Shift");
                });

            modelBuilder.Entity("Persistence.Entities.Doctor", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("FeesDoctors");

                    b.Navigation("PatientBookings");

                    b.Navigation("Prescriptions");

                    b.Navigation("ScheduleDoctors");
                });

            modelBuilder.Entity("Persistence.Entities.MedicineProvider", b =>
                {
                    b.Navigation("Medicines");
                });

            modelBuilder.Entity("Persistence.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Persistence.Entities.Patient", b =>
                {
                    b.Navigation("FeesDoctors");

                    b.Navigation("Orders");

                    b.Navigation("PatientBookings");

                    b.Navigation("Payments");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("Persistence.Entities.Prescription", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("Persistence.Entities.User", b =>
                {
                    b.Navigation("Doctor");

                    b.Navigation("MedicineProvider");

                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
