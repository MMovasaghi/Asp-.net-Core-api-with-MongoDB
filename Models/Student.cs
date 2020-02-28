using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AspMongo.Models
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string school { get; set; }
    }
}