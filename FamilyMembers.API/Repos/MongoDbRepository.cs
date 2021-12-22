using FamilyMembers.API.Attributes;
using MongoDB.Driver;

namespace FamilyMembers.API.Repos
{
    public class MongoDbRepository<T> : IMongoDbRepository<T> where T : class
    {
        public IMongoDatabase Database { get; }
        public MongoDbRepository(IMongoClient client)
        {
            Database = client.GetDatabase("cosmos-mongodb-test-project");
        }

        public async Task InsertOneAsync(T model)
        {
            var collectionName = GetCollectionName();

            var collection = Database.GetCollection<T>(collectionName);

            await collection.InsertOneAsync(model);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var collectionName = GetCollectionName();

            var collection = Database.GetCollection<T>(collectionName);

            return await collection.AsQueryable<T>().ToListAsync();
        }

        private static string GetCollectionName()
        {
            var attribute = typeof(T).GetCustomAttributes(typeof(BsonCollectionAttribute), true).FirstOrDefault()
                as BsonCollectionAttribute;

            if (attribute is not null) {
                return attribute.CollectionName;
            } 

            return string.Empty;
        }
    }
}