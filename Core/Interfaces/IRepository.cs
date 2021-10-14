using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoBD.GenericRepository.Core.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task AddAsync(TEntity obj);
        Task<TEntity> GetByIdAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task UpdateAsync(TEntity obj, Guid id);
        Task RemoveAsync(Guid id);
    }
}
