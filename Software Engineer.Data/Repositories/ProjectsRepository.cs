using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Core.Repositories;
using Software_Engineer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Software_Engineer.Data.Repositories
{
    public class ProjectsRepository : IProjectsRepository
    {
        private readonly DataContext _context;
        public ProjectsRepository(DataContext context)
        {
            _context = context;
        }
        public async Task DeleteAsync(int id)
        {
            var project2 = GetByIdAsync(id).Result;
            _context.Projects.Remove(project2);
           await _context.SaveChangesAsync();
        }

        public async Task< IEnumerable<Projects>> GetAsync()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<Projects> GetByIdAsync(int id)
        {
            return await _context.Projects.FindAsync( id);
             
        }

        public async Task PostAsync([FromBody] Projects project)
        {
            _context.Projects.Add(project);
           await _context.SaveChangesAsync();

        }

        public async Task PutAsync(int id, [FromBody] Projects project)
        {
            var project2 = _context.Projects.ToList().Find(project => project.Id == id);
            project2.NameProject = project.NameProject;
            project2.CreationDate = project.CreationDate;
          await  _context.SaveChangesAsync();
        }
    }
}
