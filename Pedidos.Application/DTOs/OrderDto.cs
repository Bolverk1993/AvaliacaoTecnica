using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pedidos.Domain.Enums;
namespace Pedidos.Application.DTOs
{
    public class OrderDto
    {
        public OrderDto(Guid id, DateTime orderDate, OrderStatus status) 
        {
            this.Id = id;
    this.OrderDate = orderDate;
    this.Status = status;
   
        }
                public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItemDto> Items { get; set; }
    }
}