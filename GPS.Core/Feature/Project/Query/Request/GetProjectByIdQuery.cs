using GraduationProjectStore.Core.Feature.Projects.Query.Model;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Projects.Query.Request
{
    public class GetProjectByIdQuery : IRequest<Result<ProjectModel>>
    {
        public GetProjectByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; }
    }
}
