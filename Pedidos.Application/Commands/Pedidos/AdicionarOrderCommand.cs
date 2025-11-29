using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Pedidos.Application.DTOs;

namespace Pedidos.Application.Commands.Pedidos
{
    public class AdicionarOrderCommand : IRequest<Guid>
    {
       public Guid CustomerId { get; set; }
        public List<OrderItemDto> Items { get; set; } 
    }
}