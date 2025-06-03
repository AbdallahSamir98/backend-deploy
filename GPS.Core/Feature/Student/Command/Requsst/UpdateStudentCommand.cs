using GraduationProjecrStore.Infrastructure.Domain.DTOs.Student;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Students.Command.Requsst
{
    public class UpdateStudentCommand : IRequest<Result<string>>
    {
        public UpdateStudentCommand(UpdateStudentDTO student)
        {
            this.Student = student;
        }

        public UpdateStudentDTO Student { get; }
    }

    
}

