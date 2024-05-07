using Tatook.Shared.Entities;

namespace Tatook.Domain.Entities.Plans
{
    public class Plan : BaseEntity
    {
        protected Plan()
        {
            //EF CORE
        }
        public Plan(string name, decimal price, int quantityEmployees)
        {
            Name = name;
            Price = price;
            QuantityEmployees = quantityEmployees;
        }

        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityEmployees { get; private set; }
    }
}
