using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace BookshelfAPI.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("isbn")]
        public string ISBN { get; set; }

        [BsonElement("publishYear")]
        public int PublishYear { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("author")]
        public string Author { get; set; }

        [BsonElement("image")]
        public string Image { get; set; }

    }
}
