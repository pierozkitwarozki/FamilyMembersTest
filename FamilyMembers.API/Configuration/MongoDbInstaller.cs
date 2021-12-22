using System.Security.Authentication;
using MongoDB.Driver;

namespace FamilyMembers.API.Configuration
{
    public static class MongoDbInstaller
    {   
        public static IServiceCollection RegisterMongoDb(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = 
                configuration["MongoDbConnectionString:Uri"];

            var settings = MongoClientSettings.FromUrl(
                new MongoUrl(connectionString)
            );

            settings.SslSettings = 
                new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };

            services.AddSingleton<IMongoClient>(new MongoClient(settings));

            return services;
        }
    }
}