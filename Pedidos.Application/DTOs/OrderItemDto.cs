using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Application.DTOs
{
    public class OrderItemDto
    {
        public OrderItemDto(Guid productId, int quantity, decimal totalPrice) 
        {
            this.ProductId = productId;
    this.Quantity = quantity;
    this.TotalPrice = totalPrice;
   
        }
                public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}