namespace FamilyMembers.API.Repos
{
    public interface IMongoDbRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task InsertOneAsync(T model);
    }
}