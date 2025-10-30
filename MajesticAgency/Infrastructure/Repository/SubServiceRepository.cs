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
    public class SubServiceRepository :ISubService
    {
        private readonly MajesticDbContext _context;

        public SubServiceRepository(MajesticDbContext context)
        {
            _context = context;
        }

        public async Task<List<SubService>> GetSubServices(int id)
        {
            var subService = await _context.SubServices.ToListAsync();
            return subService;
        }
    }
}
