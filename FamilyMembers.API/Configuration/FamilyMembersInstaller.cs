using FamilyMembers.API.Models;
using FamilyMembers.API.Repos;
using FamilyMembers.API.Services;

namespace FamilyMembers.API.Configuration
{
    public static class FamilyMembersInstaller
    {
        public static IServiceCollection RegisterFamilyMembers(this IServiceCollection services)
        {
            services.AddScoped<IMongoDbRepository<FamilyMember>, MongoDbRepository<FamilyMember>>();
            services.AddScoped<IFamilyMemberService, FamilyMemberService>();

            return services;
        }
    }
}