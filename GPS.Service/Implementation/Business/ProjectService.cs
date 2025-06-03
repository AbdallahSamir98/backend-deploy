using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjecrStore.Infrastructure.Persistence.Context;
using GraduationProjecrStore.Infrastructure.Repository;
using GraduationProjectStore.Service.Abstraction.Business;

namespace GraduationProjectStore.Service.Implementation.Business
{
    public class ProjectService : MainRepository<Project>, IProjectService
    {
        private readonly AppDbContext _app;
        public ProjectService(AppDbContext app) : base(app)
        {
            _app = app;
        }

        public async ValueTask<ICollection<Project>> GetByDepartment(int departmentId)
        {
           var projects = _app.Projects.Where(p => p.DepartmentId == departmentId).ToList();
            return projects;
        }

        public async ValueTask<ICollection<Project>> GetBySupervisor(int supervisorId)
        {
            var projects = _app.Projects.Where(p => p.SupervisorId == supervisorId).ToList();
            return projects;
        }

        public async ValueTask<ICollection<Project>> GetByYear(int year)
        {
            var projects = _app.Projects.Where(p => p.UploadAt.Year == year).ToList();
            return projects;
        }
    }
}
