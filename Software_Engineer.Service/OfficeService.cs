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
    public class OfficeService : IOfficeService
    {
        private readonly IOfficeRepository _officeRepository;
      public OfficeService(IOfficeRepository officeRepository)
        {
            _officeRepository = officeRepository;
        }

        public async Task DeleteAsync(int id)
        { 
            await _officeRepository.DeleteAsync(id);
        }

        public async Task< IEnumerable<Office>> GetAsync()
        {
            return await _officeRepository.GetAllAsync();
        }

        public async Task<Office> GetAsync(int id)
        {
            return await _officeRepository.GetAsync(id);   
        }

        public async Task PostAsync([FromBody] Office office)
        {
            await _officeRepository.PostAsync(office);
        }

        public async Task PutAsync(int id, [FromBody] Office office1)
        {
            await _officeRepository.PutAsync(id, office1);  
        }
    }
}
