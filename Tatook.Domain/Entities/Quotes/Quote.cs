using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatook.Domain.Entities.Users;
using Tatook.Domain.Enums;
using Tatook.Shared.Entities;

namespace Tatook.Domain.Entities.Quotes
{
    public class Quote : BaseEntity
    {
        public Quote(decimal price, DateTime createDate, DateTime responseDate, User tattoist, User user, EQuotesStatus status)
        {
            Price = price;
            CreateDate = createDate;
            ResponseDate = responseDate;
            Tattoist = tattoist;
            User = user;
            Status = status;
        }

        public decimal Price { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime ResponseDate { get; private set; }
        public User Tattoist { get; private set; }
        public User User { get; private set; }
        public EQuotesStatus Status { get; private set; }

    }
}
