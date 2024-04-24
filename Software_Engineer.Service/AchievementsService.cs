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
    public class AchievementsService : IAchievementsService
    {
        private readonly IAchievementsRepository _achievementsRepository;

        public AchievementsService(IAchievementsRepository achievementsRepository)
        {
            _achievementsRepository = achievementsRepository;
        }

     

        public async Task< IEnumerable<Achievements>> GetAsync()
        {
            return await _achievementsRepository.GetAsync();
        }

        public async Task< Achievements> GetByIdAsync(int id)
        {
            return await _achievementsRepository.GetByIdAsync(id);
        }

        public async Task PostAsync([FromBody] Achievements achievement)
        {
           await _achievementsRepository.PostAsync(achievement);
        }

        public async Task PutAsync(int id, [FromBody] Achievements achievement)
        {
           await _achievementsRepository.PutAsync(id, achievement);
        }
        public async Task DeleteAsync(int id)
        {
            await _achievementsRepository.DeleteAsync(id);    
            
        }
    }
}
