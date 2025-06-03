using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Projects.Command.Request
{
    public class DeleteProjectCommand : IRequest<Result<string>>
    {
        public DeleteProjectCommand(int id)
        {
            this.Id = id;
        }
        public int Id { get; }  
    }
}
