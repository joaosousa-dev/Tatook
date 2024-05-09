using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Tatook.Shared.Commands;

namespace Tatook.Domain.Commands
{
    public class CommandResult : ICommandResult
    {
        public CommandResult()
        {
        }

        public CommandResult(HttpStatusCode status, bool success, object message)
        {
            StatusCode = (int)status;
            Success = success;
            Message = message;
        }
        public int StatusCode { get; set; }
        public bool Success { get; set; }
        public object Message { get; set; }
    }
}
