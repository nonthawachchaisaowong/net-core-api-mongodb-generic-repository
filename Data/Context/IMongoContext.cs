using MongoDB.Driver;
using System;

namespace MongoBD.GenericRepository.Data.Context
{
    public interface IMongoContext : IDisposable
    {   
        IMongoCollection<T> GetCollection<T>(string name);
    }
}
