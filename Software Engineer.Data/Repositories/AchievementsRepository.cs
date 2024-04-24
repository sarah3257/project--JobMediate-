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
    public class AchievementsRepository : IAchievementsRepository
    {
        private readonly DataContext _context;
        public AchievementsRepository(DataContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(int id)
        {
            var ach = GetByIdAsync(id).Result;
            _context.Achievements.Remove(ach);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Achievements>> GetAsync()
        {
            return await _context.Achievements.ToListAsync();
        }

        public async Task<Achievements> GetByIdAsync(int id)
        {
            return await _context.Achievements.FindAsync(id);
            
        }

        public async Task PostAsync([FromBody] Achievements achievement)
        {
            _context.Achievements.Add(new Achievements
            {
                Id = _context.countA++,
                Name = achievement.Name
            });
            await _context.SaveChangesAsync();

        }

        public async Task PutAsync(int id, [FromBody] Achievements achievement)
        {
            var ach = GetByIdAsync(id).Result;
             ach.Name = achievement.Name;
           await _context.SaveChangesAsync();

        }
    }
}
