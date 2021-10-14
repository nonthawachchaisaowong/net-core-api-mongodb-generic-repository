using MongoBD.GenericRepository.Core.Interfaces;
using MongoBD.GenericRepository.Data.Context;

namespace MongoBD.GenericRepository.Data
{
    public class GenericRepository<TEntity> : BaseRepository<TEntity>, IRepository<TEntity> where TEntity : class
    {
        public GenericRepository(IMongoContext context) : base(context)
        {
        }
    }
}

