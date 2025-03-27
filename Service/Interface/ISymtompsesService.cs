using Application.DTOs.Response;
using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ISymtompsesService
    {
        Task<List<SymptomDTO>> GetAllSymtoms();
    }
}
