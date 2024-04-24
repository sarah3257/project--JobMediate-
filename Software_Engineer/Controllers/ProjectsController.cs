using Microsoft.AspNetCore.Mvc;
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
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectsService _projectsService;
        private readonly IMapper _mapper;

        public ProjectsController(IProjectsService projectsService, IMapper mapper)
        {
           _projectsService  = projectsService;
            _mapper = mapper;

        }


        // GET: api/<ProjectsController>
        [HttpGet]
        public async Task< ActionResult> Get()
        {
            var listP = await _projectsService.GetAsync();
            var listPDto = new List<ProjectsDto>();

            foreach (var project in listP)
            {
                listPDto.Add(_mapper.Map<ProjectsDto>(project));
            }
            return Ok(listPDto);
        }
       

        // GET api/<ProjectsController>/5
        [HttpGet("{id}")]
        public async Task< ProjectsDto> Get(int id)
        {
            var project = await _projectsService.GetAsync(id);
            return _mapper.Map<ProjectsDto>(project);
        }
      

        // POST api/<ProjectsController>
        [HttpPost]
        public async Task Post([FromBody] ProjectsModel projectModel)
        {
            var project = new Projects()
            {
                NameProject = projectModel.NameProject,
                CreationDate = projectModel.CreationDate,
                AchievementId=projectModel.AchievementId
            };
           await _projectsService.PostAsync(project);
        }

        // PUT api/<ProjectsController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] ProjectsModel projectModel)
        {
            var project = new Projects()
            {
                NameProject = projectModel.NameProject,
                CreationDate = projectModel.CreationDate,
                AchievementId = projectModel.AchievementId
            };
             await _projectsService.PutAsync(id, project);  
        }

        // DELETE api/<ProjectsController>/5
        [HttpDelete("{id}")]
        public async Task< ActionResult> Delete(int id)
        {
            
            var project = _projectsService.GetAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            await _projectsService.DeleteAsync(id);
            return NoContent();


        }
    }
}
