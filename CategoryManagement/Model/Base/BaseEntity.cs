﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CategoryManagement.Model.Base
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
