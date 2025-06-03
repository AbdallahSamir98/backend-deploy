using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjecrStore.Infrastructure.Domain.DTOs.Student;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Students.Command.Requsst
{
    public class CreateStudentCommand : IRequest<Result<string>>
    {
        public CreateStudentCommand(CreateStudentDTO student)
        {
            this.Student = student;
        }

        public CreateStudentDTO Student { get; }
    }
}
