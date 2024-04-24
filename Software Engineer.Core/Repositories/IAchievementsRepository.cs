using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineer.Core.Repositories
{
    public  interface IAchievementsRepository
    {
        Task < IEnumerable<Achievements>> GetAsync();
      
        Task<Achievements> GetByIdAsync(int id);
      
        Task PostAsync([FromBody] Achievements achievement);
      
        Task PutAsync(int id, [FromBody] Achievements achievement);
       
        Task DeleteAsync(int id);
    }
}
