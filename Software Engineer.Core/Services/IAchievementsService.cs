using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_Engineer.Core.Entities;
using Microsoft.AspNetCore.Mvc;


namespace Software_Engineer.Core.Services
{
    public interface IAchievementsService
    {
        Task<IEnumerable<Achievements>> GetAsync();

        Task<Achievements> GetByIdAsync(int id);

        Task PostAsync([FromBody] Achievements achievement);
       
        Task PutAsync(int id, [FromBody] Achievements achievement);

        Task DeleteAsync(int id);
    }
}
