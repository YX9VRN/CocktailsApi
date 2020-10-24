using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CocktailsApi.Models
{
    public class Cocktail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("Name")]
        public string Name { get; set; }
        public IEnumerable<string> Ingredients { get; set; }
        public IEnumerable<string> Steps { get; set; }
        public string Description { get; set; }
    }
}
