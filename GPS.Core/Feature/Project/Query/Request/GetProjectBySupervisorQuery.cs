using GraduationProjectStore.Core.Feature.Projects.Query.Model;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Projects.Query.Request
{
    public class GetProjectBySupervisorQuery : IRequest<Result<ICollection<ProjectModel>>>
    {
        public GetProjectBySupervisorQuery(int supervisorid)
        {
            this.SupervisorId = supervisorid;
        }
        public int SupervisorId { get; }
    }
}
