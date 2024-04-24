using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineer.Core.Repositories
{
    public interface IProjectsRepository
    {
        Task<IEnumerable<Projects>> GetAsync();

        Task<Projects> GetByIdAsync(int id);

        Task PostAsync([FromBody] Projects project);

        Task PutAsync(int id, [FromBody] Projects project);

        Task DeleteAsync(int id);
    }
}
