using Microsoft.AspNetCore.Mvc;
using Software_Engineer.API.Models;
using Software_Engineer.Core.Entities;
using Software_Engineer.Core.Services;
using Software_Engineer.Service;
using AutoMapper;
using Software_Engineer.Core.DTOs;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Software_Engineer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AchievementsController : ControllerBase
    {
        private readonly IAchievementsService _AchievementsService;
        private readonly IMapper _mapper;

        public AchievementsController(IAchievementsService achievementsService, IMapper mapper)
        {
            _AchievementsService = achievementsService;
            _mapper=mapper;
        }

        // GET: api/<AchievementsController>
        [HttpGet]
        public async Task< ActionResult> Get()
        {
            var listA = await _AchievementsService.GetAsync();
            var listADto =new List<AchievementsDto>();

            foreach (var achi in listA)
            {
                listADto.Add(_mapper.Map<AchievementsDto>(achi));
            }
            return Ok(listADto);
        }

        // GET api/<AchievementsController>/5
        [HttpGet("{id}")]
        public async Task< AchievementsDto> Get(int id)
        {
            var achievements = await _AchievementsService.GetByIdAsync(id);
            return _mapper.Map<AchievementsDto>(achievements);
        } 

        // POST api/<AchievementsController>
        [HttpPost]
        public async Task Post([FromBody] AchievementsModel achievementModel)
        {
            var achievement = new Achievements
            {
                Name = achievementModel.Name

            };
           await _AchievementsService.PostAsync(achievement);

        }

        // PUT api/<AchievementsController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] AchievementsModel achievementModel)
        {
            var achievement=new Achievements { Name = achievementModel.Name };
            await _AchievementsService.PutAsync(id, achievement);
        }

        // DELETE api/<AchievementsController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
          await _AchievementsService.DeleteAsync(id);
        }
    }
}
