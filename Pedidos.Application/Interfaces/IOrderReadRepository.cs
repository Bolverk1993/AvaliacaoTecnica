using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pedidos.Application.DTOs;

namespace Pedidos.Application.Interfaces
{
    public interface IOrderReadRepository
    {
        Task<OrderDto> GetByIdAsync(Guid id);
        Task<List<OrderDto>> GetAllAsync();
        Task AddOrUpdateAsync(OrderDto order);
        Task RemoveAsync(Guid id);
    }
}