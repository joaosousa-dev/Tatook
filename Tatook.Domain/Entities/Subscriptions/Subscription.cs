using Tatook.Domain.Entities.Plans;
using Tatook.Shared.Entities;

namespace Tatook.Domain.Entities.Subscriptions
{
    public class Subscription : BaseEntity
    {
        public Subscription(DateTime startDate, DateTime expireDate, Plan plan, bool active)
        {
            StartDate = startDate;
            ExpireDate = expireDate;
            Plan = plan;
            Active = true;
        }

        public DateTime StartDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public Plan Plan { get; private set; }
        public bool Active { get; private set; }
    }
}