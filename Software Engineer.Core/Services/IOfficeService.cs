﻿using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineer.Core.Services
{
    public interface IOfficeService
    {
        Task<IEnumerable<Office>> GetAsync();

        Task<Office> GetAsync(int id);
        Task PostAsync([FromBody] Office office);

        Task PutAsync(int id, [FromBody] Office office1);

        Task DeleteAsync(int id);
    }
}
