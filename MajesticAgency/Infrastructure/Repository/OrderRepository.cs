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
    public class OrderRepository : IOrder
    {

        private readonly MajesticDbContext _context;

        public OrderRepository(MajesticDbContext context)
        {
            _context = context;
        }
        public async Task<Order> CreateOrder(Order order)
        {
            _context.Entry(order).State = EntityState.Added;

            await _context.SaveChangesAsync();

            return order;
        }
    }
}
