using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineer.Core.Services
{
    public interface IProjectsService
    {
        Task PutAsync(int id, [FromBody] Projects project);

        Task PostAsync([FromBody] Projects project);

        Task<ActionResult<Projects>> GetAsync(int id);

        Task<IEnumerable<Projects>> GetAsync();

        Task DeleteAsync(int id);
    }
}
