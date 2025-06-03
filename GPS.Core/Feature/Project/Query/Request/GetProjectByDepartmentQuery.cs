using GraduationProjectStore.Core.Feature.Projects.Query.Model;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Projects.Query.Request
{
    public class GetProjectByDepartmentQuery : IRequest<Result<ICollection<ProjectModel>>>   
    {
        public GetProjectByDepartmentQuery(int departmentid)
        {
            this.DepartmentId = departmentid;
        }
        public int DepartmentId { get; }
    }
}
