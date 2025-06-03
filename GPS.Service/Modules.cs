using GraduationProjectStore.Service.Abstraction.Business;
using GraduationProjectStore.Service.Abstraction.Security;
using GraduationProjectStore.Service.Implementation.Business;
using GraduationProjectStore.Service.Implementation.Security;
using GraduationProjectStore.Service.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace GraduationProjectStore.Service
{
    public static class Modules
    {
        public static void AddServiceModules(this IServiceCollection service)
        {
            service.AddTransient<IUnitOfWork, UnitOfWork>();
            service.AddTransient<IMailService, MailService>();
            service.AddTransient<IContactService, ContactServive>();
            service.AddTransient<IStudentService, StudentService>();
            service.AddTransient<IProjectService, ProjectService>();
            service.AddTransient<ISupervisorService, SupervisorService>();
            service.AddTransient<IDepartmentService, DepartmentService>();
            service.AddTransient<IAuthorizationService, AuthorizationService>();
            service.AddTransient<IAuthenticationService, AuthenticationService>();
        }
    }
}
