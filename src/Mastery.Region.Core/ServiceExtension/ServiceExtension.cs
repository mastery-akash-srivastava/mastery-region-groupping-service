using Mastery.Region.Repos.DBContext;
using Mastery.Region.Repos.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Mastery.Region.Core.Extension
{
    public static class ServiceExtension
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection service)
        {
            service.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }

}
