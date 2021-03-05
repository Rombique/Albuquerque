using Albuquerque.Core.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Albuquerque.Core.Data
{
    public class MongoContext : IMongoContext
    {
        private readonly IMongoDatabase _db;

        public MongoContext(IConfiguration config)
        {
            var client = new MongoClient(config.GetSection("DatabaseSettings:ConnectionString").Value);
            _db = client.GetDatabase(config.GetSection("DatabaseSettings:Name").Value);
            Issues = _db.GetCollection<Issue>(nameof(Issues).ToLowerInvariant());
        }
        
        public IMongoCollection<Issue> Issues { get; set; }
    }
}