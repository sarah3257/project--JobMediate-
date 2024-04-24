using Microsoft.AspNetCore.Mvc;
//using Software_Engineer.Core.Services;
using Software_Engineer.Core.Entities;
using Software_Engineer.Core.Services;
using Software_Engineer.Service;
using Software_Engineer.API.Models;
using AutoMapper;
using Software_Engineer.Core.DTOs;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Software_Engineer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        
        private readonly IOfficeService _officeService;
        private readonly IMapper _mapper;

        public OfficeController(IOfficeService officeService, IMapper mapper)
        {
            _officeService = officeService;
            _mapper = mapper;

        }


        // GET: api/<OfficeController>
        [HttpGet]
        public async Task< ActionResult> Get()
        {
            var listO = await _officeService.GetAsync();
            var listODto = new List<OfficesDto>();

            foreach (var office in listO)
            {
                listODto.Add(_mapper.Map<OfficesDto>(office));
            }
            return Ok(listODto);
        }
     

        // GET api/<OfficeController>/5
        [HttpGet("{id}")]
        public async Task< OfficesDto> Get(int id)
        {        
            var office= await _officeService.GetAsync(id);  
            return _mapper.Map<OfficesDto>(office);
        }
      

        // POST api/<OfficeController>
        [HttpPost]
        public async Task Post([FromBody] OfficeModel officeModel)
        {
            var office=new Office() { Name = officeModel.Name };
           await  _officeService.PostAsync(office);
        }

        // PUT api/<OfficeController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] OfficeModel officeModel1)
        {
            var office1=new Office() { Name = officeModel1.Name };
           await _officeService.PutAsync(id, office1);    
        }

        // DELETE api/<OfficeController>/5
        [HttpDelete("{id}")]
        public async Task< ActionResult> Delete(int id)
        {
            var office=_officeService.GetAsync(id);
            if (office == null)
            {
                return NotFound();
            }
            await _officeService.DeleteAsync(id);
            return NoContent();

        }
    }
}
