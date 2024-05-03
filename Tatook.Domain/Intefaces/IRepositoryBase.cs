using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tatook.Domain.Intefaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        public Task Create(TEntity entity);
        public Task Update(TEntity entity);
        public Task<IList<TEntity>> GetAllAsync();
        public Task<TEntity> GetById(int id);
        public Task Save(TEntity entity);
    }
}
