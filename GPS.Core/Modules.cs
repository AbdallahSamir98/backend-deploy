using System.Reflection;
using GraduationProjectStore.Core.Feature.Authentications.Query.Request;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace GraduationProjectStore.Core
{
    public static class Modules
    {
        public static void AddCoreModules(this IServiceCollection service)
        {

            // to add password defualt settings
            service.Configure<IdentityOptions>
            (
                options => 
                {
                    options.Password.RequiredLength = 8;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireDigit = false;
                }
            );

            // to register mapper and mediatr
            service.AddMediatR(Assembly.GetExecutingAssembly());
            service.AddAutoMapper(Assembly.GetExecutingAssembly());

        }
    }
}
