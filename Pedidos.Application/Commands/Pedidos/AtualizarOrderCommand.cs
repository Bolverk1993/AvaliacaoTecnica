using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Pedidos.Application.DTOs;
using Pedidos.Domain.Enums;

namespace Pedidos.Application.Commands.Pedidos
{
    public class AtualizarOrderCommand : IRequest
    {
        public Guid Id { get; set; }
        public OrderStatus Status { get; set; }
    }
}