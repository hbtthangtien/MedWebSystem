using Microsoft.AspNetCore.Mvc;
using Application.Services;
using Application.DTOs.Response;
using Application.Interface;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SymptomsesController : ControllerBase
    {
        private ISymtompsesService _symptomsService;
        
        public SymptomsesController(ISymtompsesService symptomsService)
        {
            _symptomsService = symptomsService;
        }

        // GET: api/<SymptomsesController>
        [HttpGet]
        public async Task<List<SymptomDTO>> Get()
        {
            List<SymptomDTO> list = await _symptomsService.GetAllSymtoms();
            return list;
        }

        // GET api/<SymptomsesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SymptomsesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SymptomsesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SymptomsesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
