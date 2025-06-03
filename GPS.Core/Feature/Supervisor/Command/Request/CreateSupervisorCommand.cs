using GraduationProjecrStore.Infrastructure.Domain.DTOs.Supervisor;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Supervisors.Command.Request
{
    public class CreateSupervisorCommand : IRequest<Result<string>>
    {
        public CreateSupervisorCommand(CreateSupervisorDTO supervisor)
        {
            Supervisor = supervisor;
        }
        public CreateSupervisorDTO Supervisor { get;  }
    }
}
