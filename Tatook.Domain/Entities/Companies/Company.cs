using Tatook.Domain.Entities.Users;
using Tatook.Shared.Entities;

namespace Tatook.Domain.Entities.Companies
{
    public class Company : BaseEntity
    {
        public Company(string name, string? logoLink, DateTime createDate, DateTime updateDate, User? owner = null, IList<User>? employees=null)
        {
            Name = name;
            LogoLink = logoLink;
            CreateDate = createDate;
            UpdateDate = updateDate;
            Owner = owner;
            Employees = employees;
        }

        public string Name { get; private set; }
        public string? LogoLink { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime UpdateDate { get; private set; }
        public User? Owner { get; private set; }
        public IList<User>? Employees { get; private set; }
    }
}
