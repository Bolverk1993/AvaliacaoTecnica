using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Pedidos.Application.Commands.Pedidos
{
    public class RemoverOrderCommand : IRequest
    {
       public Guid Id { get; set; } 
    }
}