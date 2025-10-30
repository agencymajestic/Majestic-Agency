using Core.Entities;
using Core.Interface;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ServiceRepository : IService
    {
        private readonly MajesticDbContext _context;

        public ServiceRepository(MajesticDbContext context)
        {
            _context = context;
        }
        public async Task<Service> GetService(int id)
        {
            var service = await _context.Services.Include(x=>x.subServices).FirstOrDefaultAsync(x => x.Id == id);
            return service;
        }

        public async Task<List<Service>> GetServices()
        {
            var service = await _context.Services.ToListAsync();
            return service;
        }
    }
}
