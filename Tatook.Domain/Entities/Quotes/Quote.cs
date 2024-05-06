using Flunt.Validations;
using Tatook.Domain.Entities.Customers;
using Tatook.Domain.Entities.Users;
using Tatook.Domain.Enums;
using Tatook.Shared.Entities;

namespace Tatook.Domain.Entities.Quotes
{
    public class Quote : BaseEntity
    {
        public Quote(User tattooist, Customer customer, string message, decimal width, decimal height, string color)
        {
            Price = 0;
            CreateDate = DateTime.UtcNow;
            ResponseDate = null;
            Tattooist = tattooist;
            Customer = customer;
            Status = EQuotesStatus.OPENED;
            Message = message;
            Width = width;
            Height = height;
            Color = color;
            Validate();
        }

        public decimal Price { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime? ResponseDate { get; private set; }
        public User? Tattooist { get; private set; }
        public Customer Customer { get; private set; }
        public EQuotesStatus Status { get; private set; }
        public string? Message { get; private set; }
        public decimal Width { get; private set; }
        public decimal Height { get; private set; }
        public string Color { get; private set; }

        public void UpdatePrice(decimal price)
        {
            Price = price;
        }
        public void UpdateResponseDate()
        {
            ResponseDate = DateTime.UtcNow;
        }
        public void UpdateStatus(EQuotesStatus newStatus)
        {
            Status = newStatus;
        }
        public void UpdateTattooist(User tattooist)
        {
            Tattooist = tattooist;
        }
        private void Validate()
        {
            // Deve ter um tatuador associado 
            // Deve ter um cliente
            // data de resposta é assim que o orçamento é respondido
            // inciar como Aberto status
            // preço é 0 no inicio e é atibuido na resposta
            AddNotifications(new Contract<Quote>()
                .Requires()
                .IsNotNull(Width, "Width", "width cannot be null")
                .IsGreaterThan(Width, 0, "Width", "Width must be greater than 0")
                .IsNotNull(Height, "Height", "Height cannot be null")
                .IsGreaterThan(Height, 0, "Height", "Width must be greater than 0")
                .IsNotNullOrWhiteSpace(Color, "Color", "Color cannot be null Or empty")
                .IsLowerThan(Message, 200, "Message", "Message cannot be greater than 200 characters")
                .IsNotNull(Customer, "Customer", "Custumer cannot be null")
                );


        }

    }
}
