using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Supervisors.Command.Request
{
    public class DeleteSupervisorCommand : IRequest<Result<string>>
    {
        public DeleteSupervisorCommand(int id)
        {
            this.Id = id;
        }

        public int Id { get; }
    }
}
