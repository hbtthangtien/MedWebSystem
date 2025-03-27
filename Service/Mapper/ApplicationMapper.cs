using Application.DTOs.Response;
using AutoMapper;
using Microsoft.AspNetCore.HttpLogging;
using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() { 
            CreateMap<Doctor,DoctorDTO>().ReverseMap();
            CreateMap<Symptoms,SymptomDTO>().ReverseMap();
            CreateMap<Medicine, MedicineDTO>().ReverseMap();
            CreateMap<Disease, DiseaseDTO>().ReverseMap();
        }
    }
}
