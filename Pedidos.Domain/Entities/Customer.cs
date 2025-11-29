namespace Pedidos.Domain.Entities
{
    public class Customer
    {
        public Customer(Guid id, string name, string email, string phone) 
        {
            this.Id = id;
    this.Name = name;
    this.Email = email;
    this.Phone = phone;
   
        }
                public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
