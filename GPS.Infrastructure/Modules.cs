using GraduationProjecrStore.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace GraduationProjecrStore.Infrastructure
{
    public static class Modules
    {
        public static void AddInfrastructureModules(this IServiceCollection service)
        {
            service.AddTransient(typeof(IMainRepository<>),typeof(MainRepository<>));
        }
    }
}
