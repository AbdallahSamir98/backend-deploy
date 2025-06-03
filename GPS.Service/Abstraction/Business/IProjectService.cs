using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjecrStore.Infrastructure.Repository;

namespace GraduationProjectStore.Service.Abstraction.Business
{
    public interface IProjectService : IMainRepository<Project>
    {
        ValueTask<ICollection<Project>> GetByYear(int year);
        ValueTask<ICollection<Project>> GetByDepartment(int departmentId);
        ValueTask<ICollection<Project>> GetBySupervisor(int supervisorId);
    }
}

