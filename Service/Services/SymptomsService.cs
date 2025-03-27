using Application.DTOs.Response;
using Application.Interface;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using Persistence.Repositories;

namespace Application.Services
{
   


    public class SymptomsService : ISymtompsesService
    {
        private readonly ISymtompsesRespository _symtompsesRepository;

        public SymptomsService(ISymtompsesRespository symtompsesRespository)
        {
            _symtompsesRepository = symtompsesRespository;
        }

        public async Task<List<SymptomDTO>> GetAllSymtoms()
        {
            try
            {
                var symptoms = await _symtompsesRepository.GetAll();
                return await symptoms
                .Select(s => new SymptomDTO
                {
                    Id = s.Id,
                    Descriptions = s.Descriptions
                }).ToListAsync(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null ;
            
        }
    }
}
