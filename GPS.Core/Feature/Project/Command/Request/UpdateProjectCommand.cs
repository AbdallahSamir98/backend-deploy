using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Projects.Command.Request
{
    public class UpdateProjectCommand  : IRequest<Result<string>>
    {
        public UpdateProjectCommand(UpdateProjectDTO projectDTO)
        {
            this.projectDTO = projectDTO;
        }

        public UpdateProjectDTO projectDTO { get; }
    }
}
