using MongoDB.Driver;

namespace personListingsAPI.Servises
{
    public class MongoService
    {
        private readonly IMongoDatabase _database;

        public MongoService(IConfiguration config)
        {
            var connectionString = config.GetConnectionString("MongoDBConnectionString");
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase("persons");
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _database.GetCollection<T>(name);
        }
    }
}
