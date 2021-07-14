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

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("nickname")]
        public string Nickname { get; set; }

        [BsonElement("score")]
        public int Score { get; set; }

        [BsonElement("classification")]
        public int Classification { get; set; }
    }
}