using GraduationProjecrStore.Infrastructure.Domain.DTOs.Supervisor;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Supervisors.Command.Request
{
    public class UpdateSupervisorCommand : IRequest<Result<string>>
    {
        public UpdateSupervisorCommand(UpdateSupervisorDTO supervisor)
        {
            this.supervisor = supervisor;
        }

        public UpdateSupervisorDTO supervisor { get; }
    }
}
