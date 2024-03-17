﻿using Jumia.Application.Contract;
using Jumia.Context;
using Jumia.Model;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.Entity;

namespace Jumia.InfraStructure.Repository
{
    public class OrderRepository : Repository<Order, int>, IOrderReposatory
    {
        private readonly JumiaContext context;

        public OrderRepository(JumiaContext context) : base(context) 
        {
            this.context = context;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await context.orders
                .Include(o => o.User)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task UpdateOrderStatusAsync(int orderId, string newStatus)
        {
            var order = await context.orders.FindAsync(orderId);
            if (order != null)
            {
                order.Status = newStatus;
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteOrderAsync(int orderId)
        {
            var order = await context.orders.FindAsync(orderId);
            if (order != null)
            {
                context.orders.Remove(order);
                await context.SaveChangesAsync();
            }
        }
    }

}


