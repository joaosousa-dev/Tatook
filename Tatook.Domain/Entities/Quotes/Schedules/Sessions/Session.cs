using Tatook.Domain.Enums;
using Tatook.Shared.Entities;

namespace Tatook.Domain.Entities.Quotes.Schedules.Sessions
{
    public class Session : BaseEntity
    {
        protected Session() { }
        public Session(DateTime startDateTime, DateTime endDateTime, Schedule schedule, string scheduleLink, ESessionStatus status)
        {
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            Schedule = schedule;
            ScheduleLink = scheduleLink;
            Status = status;
        }

        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public Schedule Schedule { get; private set; }
        public string ScheduleLink { get; set; }
        public ESessionStatus Status { get; private set; }
    }
}
