using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Departments.Command.Request
{
    public class DeleteDepartmentCommand : IRequest<Result<string>>
    {
        public DeleteDepartmentCommand(int departmentId)
        {
            Id = departmentId;
        }
        public int Id { get; }
    }
}
