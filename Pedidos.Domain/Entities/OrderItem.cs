namespace Pedidos.Domain.Entities
{
    public class OrderItem
    {
        public OrderItem(Guid id, Guid orderId, Guid productId, string productName, int quantity, decimal unitPrice, decimal totalPrice) 
        {
            this.Id = id;
    this.OrderId = orderId;
    this.ProductId = productId;
    this.ProductName = productName;
    this.Quantity = quantity;
    this.UnitPrice = unitPrice;
    this.TotalPrice = totalPrice;
   
        }
                public Guid Id { get; set; }

        public Guid OrderId { get; set; }

        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
