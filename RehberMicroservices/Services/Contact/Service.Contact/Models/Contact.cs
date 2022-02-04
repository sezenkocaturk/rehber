using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Contact.Models
{
    public class Contact
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Content { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string PersonId { get; set; }
        public Contacttype Contacttype { get; set; }

        [BsonIgnore]
        public Person Person { get; set; }

    }
}
