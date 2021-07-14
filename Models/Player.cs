using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace TaurusApi
{
    public class Player
    {
        public Player(string name, string nickname, int score, int classification)
        {
            Name = name;
            Nickname = nickname;
            Score = score;
            Classification = classification;
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required]
        [BsonElement("name")]
        public string Name { get; set; }

        [Required]
        [BsonElement("nickname")]

        public string Nickname { get; set; }

        [Required]
        [BsonElement("score")]

        public int Score { get; set; }

        [Required]
        [BsonElement("classification")]
        public int Classification { get; set; }
    }
}