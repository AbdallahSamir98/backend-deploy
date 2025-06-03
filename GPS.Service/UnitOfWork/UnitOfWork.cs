using GraduationProjecrStore.Infrastructure.Persistence.Context;
using GraduationProjectStore.Service.Abstraction.Business;
using GraduationProjectStore.Service.Implementation.Business;
using GraduationProjectStore.Service.Implementation.Security;

namespace GraduationProjectStore.Service.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _app;
        public UnitOfWork(AppDbContext app)
        {
            this._app = app;
            this.StudentService = new StudentService(_app); 
            this.ProjectService = new ProjectService(_app);
            this.DepartmentService = new DepartmentService(_app);
            this.SupervisorService = new SupervisorService(_app);
            this.ContactService = new ContactServive(_app);
        }

        public IDepartmentService DepartmentService { get;  set; }

        public IStudentService StudentService { get;  set; }

        public IProjectService ProjectService  { get;  set; }

        public ISupervisorService SupervisorService { get; set; }

        public IContactService ContactService { set; get; }

        public void Dispose()
        {
            _app.Dispose();
        }

        public async Task<int> SaveChanges()
        {
            return await _app.SaveChangesAsync();
        }
    }
}
