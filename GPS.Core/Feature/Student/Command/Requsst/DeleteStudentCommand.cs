using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Students.Command.Requsst
{
    public class DeleteStudentCommand : IRequest<Result<string>>
    {
        public DeleteStudentCommand(int id)
        {
            this.Id = id;
        }

        public int Id {get; }
    }
}
