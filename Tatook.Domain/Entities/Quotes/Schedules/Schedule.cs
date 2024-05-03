using Tatook.Domain.Entities.Customers;
using Tatook.Domain.Entities.Quotes.Schedules.Sessions;
using Tatook.Domain.Entities.Users;
using Tatook.Domain.Enums;
using Tatook.Shared.Entities;

namespace Tatook.Domain.Entities.Quotes.Schedules
{
    public class Schedule : BaseEntity
    {
        public User Tattoist { get; private set; }
        public DateTime CreateDate { get; private set; }
        public IList<Session> Sessions { get; private set; }
        public string ScheduleLink { get; set; }
        public Customer Customer { get; private set; }
        public EScheduleStatus Status { get; private set; }

    }
}
