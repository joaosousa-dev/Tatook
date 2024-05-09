using Tatook.Domain.Entities.Plans;
using Tatook.Domain.Entities.Users;
using Tatook.Shared.Entities;

namespace Tatook.Domain.Entities.Subscriptions
{
    public class Subscription : BaseEntity
    {
        protected Subscription() { }
        public Subscription(DateTime startDate, DateTime expireDate, Plan plan,User? user)
        {
            StartDate = startDate;
            ExpireDate = expireDate;
            Plan = plan;
            User = user;
            Active = true;
        }

        public DateTime StartDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public Plan Plan { get; private set; }
        public User? User { get; private set; }
        public bool Active { get; private set; }
    }
}