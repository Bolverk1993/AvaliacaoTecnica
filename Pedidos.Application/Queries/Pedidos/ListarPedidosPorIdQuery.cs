using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Pedidos.Application.DTOs;

namespace Pedidos.Application.Queries.Pedidos
{
    public class ListarPedidosPorIdQuery : IRequest<OrderDto>
    {
        public Guid Id { get; set; }

        public ListarPedidosPorIdQuery(Guid id)
        {
            Id = id;
        }
    }
}