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
    public class OfficeRepository : IOfficeRepository
    {
        private readonly DataContext _context;
        public OfficeRepository(DataContext context)
        {
            _context = context;
        }
        public async Task DeleteAsync(int id)
        {
            var office2 = _context.Office.ToList().Find(office2 => office2.Id == id);  
            _context.Office.Remove(office2);
           await _context.SaveChangesAsync();
           
        }

        public async Task<IEnumerable<Office>> GetAllAsync()
        {
            return await _context.Office.ToListAsync();
        }

        public async Task<Office> GetAsync(int id)
        {
           
            return await _context.Office.FindAsync(id);
        }

        public async Task PostAsync([FromBody] Office office)
        {
            _context.Office.Add(new Office { Id = _context.CountO++, Name = office.Name });
            await _context.SaveChangesAsync();

        }

        public async Task PutAsync(int id, [FromBody] Office office1)
        {
            var office2 = _context.Office.ToList().Find(x => x.Id == id);
            office2.Name = office1.Name;
           await _context.SaveChangesAsync();
          
        }



        
    }
}
