using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjectStore.Core.Feature.Students.Query.Model;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Students.Query.Request
{
    public class GetAllStudentQuery : IRequest<Result<ICollection<StudentModel>>>
    {

    }
}
