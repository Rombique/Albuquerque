using Albuquerque.Core.Entities;
using MongoDB.Driver;

namespace Albuquerque.Core.Data
{
    public interface IMongoContext
    {
        IMongoCollection<Issue> Issues { get; set; }
    }
}