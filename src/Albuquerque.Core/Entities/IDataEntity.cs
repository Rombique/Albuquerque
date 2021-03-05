using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Albuquerque.Core.Entities
{
    public interface IDataEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string Id { get; set; }
    }
}