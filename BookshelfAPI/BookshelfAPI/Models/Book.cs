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

        public string Title { get; set; }

        public string ISBN { get; set; }

        public int PublishYear { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public string Image { get; set; }

    }
}
