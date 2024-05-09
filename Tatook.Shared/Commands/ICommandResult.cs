using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tatook.Shared.Commands
{
    public interface ICommandResult
    {
        public int StatusCode { get; set; }
        public bool Success { get; set; }
        public object Message { get; set; }
    }
}
