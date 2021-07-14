using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace TaurusApi
{

    public class PlayerService
    {
        private readonly IMongoCollection<Player> _players;

        public PlayerService(ITaurusDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _players = database.GetCollection<Player>(settings.PlayersCollectionName);
        }

        public List<Player> Get()
        {
            return _players.Find(player => true).ToList(); ;
        }

        public Player Get(string id)
        {
            return _players.Find<Player>(player => player.Id == id).FirstOrDefault();
        }

        public Player Create(Player player)
        {
            _players.InsertOne(player);
            return player;
        }

        public void Update(string id, Player playerIn)
        {
            _players.ReplaceOne(player => player.Id == id, playerIn);
        }

        public void Remove(Player playerIn)
        {
            _players.DeleteOne(player => player.Id == playerIn.Id);
        }

        public void Remove(string id)
        {
            _players.DeleteOne(player => player.Id == id);
        }
    }
}