using GraduationProjectStore.Core.Feature.Students.Query.Model;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Students.Query.Request
{
    public class GetStudentByIdQuery : IRequest<Result<StudentModel>>
    {
        public GetStudentByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
