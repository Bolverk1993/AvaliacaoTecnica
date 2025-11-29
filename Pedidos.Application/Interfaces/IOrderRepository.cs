using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pedidos.Domain.Entities;

namespace Pedidos.Application.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> AddAsync(Order order);
        Task UpdateAsync(Order order);
        Task RemoveAsync(Guid id);
        Task<Order> GetByIdAsync(Guid id);
        Task<List<Order>> GetAllAsync();
    }
}