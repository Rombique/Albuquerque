using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Albuquerque.Core.Entities
{
    public class Issue : IDataEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        public string Number { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsDone { get; set; }
        public string Comments { get; set; }
    }
}