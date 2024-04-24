using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Core.Repositories;
using Software_Engineer.Core.Services;
using Software_Engineer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineer.Service
{
    public class ProjectsService : IProjectsService
    {
        private readonly IProjectsRepository _projectsRepository;

        public ProjectsService (IProjectsRepository projectsRepository)
        {
          _projectsRepository = projectsRepository;
        }

        public async Task DeleteAsync(int id)
        {
            await _projectsRepository.DeleteAsync(id);
        }

        public async Task< IEnumerable<Projects>> GetAsync()
        {
            return await _projectsRepository.GetAsync();
        }

        public async Task< ActionResult<Projects>> GetAsync(int id)
        {
            return await _projectsRepository.GetByIdAsync(id);
        }

        public async Task PostAsync([FromBody] Projects project)
        {
           await _projectsRepository.PostAsync(project);
        }

        public async Task PutAsync(int id, [FromBody] Projects project)
        {
            await  _projectsRepository.PutAsync(id, project);    
        }
    }
}
