using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatook.Shared.ValueObjects
{
    public abstract class ValueObject : Notifiable<Notification>
    {
    }
}
