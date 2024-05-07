using Tatook.Domain.Entities.Users;
using Tatook.Shared.Entities;

namespace Tatook.Domain.Entities.Companies
{
    public class Company : BaseEntity
    {
        protected Company()
        {
            //EF CORE
        }
        public Company(string name, string? logoLink, User? owner = null)
        {
            Name = name;
            LogoLink = logoLink;
            CreateDate = DateTime.UtcNow;
            UpdateDate = DateTime.UtcNow; 
            Owner = owner;
            Employees = new List<User>();
        }

        public string Name { get; private set; }
        public string? LogoLink { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime UpdateDate { get; private set; }
        public User? Owner { get; private set; }
        public IList<User> Employees { get; private set; }
        public void AddEmployee(User employee)
        {
            Employees.Add(employee);
        }
    }

}
