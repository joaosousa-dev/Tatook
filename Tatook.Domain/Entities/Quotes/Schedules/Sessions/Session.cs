using Tatook.Domain.Enums;
using Tatook.Shared.Entities;

namespace Tatook.Domain.Entities.Quotes.Schedules.Sessions
{
    public class Session : BaseEntity
    {
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public Schedule Schedule { get; private set; }
        public ESessionStatus Status { get; private set; }
    }
}
