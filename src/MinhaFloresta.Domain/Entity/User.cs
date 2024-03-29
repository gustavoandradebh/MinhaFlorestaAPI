﻿using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace MinhaFloresta.Domain.Entity
{
    public class User: BaseEntity
    {
        [Required]
        public string Email { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        [BsonIgnore]
        public List<Plant> Plants { get; set; }
    }
}
