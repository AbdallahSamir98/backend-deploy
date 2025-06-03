using GraduationProjectStore.Service.Abstraction.Business;

namespace GraduationProjectStore.Service.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
         IStudentService StudentService { get; }
         IProjectService ProjectService { get; }
         ISupervisorService SupervisorService { get; }
         IDepartmentService DepartmentService { get; }
         public IContactService ContactService { get; }
         Task<int> SaveChanges();
    }
}
