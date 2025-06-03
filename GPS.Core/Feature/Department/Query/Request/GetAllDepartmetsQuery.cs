using GraduationProjectStore.Core.Feature.Departments.Query.Models;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Departments.Query.Request
{
    public class GetAllDepartmetsQuery : IRequest<Result<ICollection<DepartmentModel>>>
    {

    }
}
