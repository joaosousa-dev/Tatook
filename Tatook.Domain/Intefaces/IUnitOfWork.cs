using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatook.Domain.Intefaces
{
    public interface IUnitOfWork
    {
        public Task Commit();
    }
}
