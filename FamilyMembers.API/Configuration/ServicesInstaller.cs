namespace FamilyMembers.API.Configuration
{
    public static class ServicesInstaller
    {
        public static IServiceCollection InstallServicesAndControllers(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.RegisterMongoDb(configuration);
            services.RegisterFamilyMembers();

            return services;
        }
    }
}