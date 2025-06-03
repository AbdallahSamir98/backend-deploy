using GraduationProjectStore.Core.Feature.Projects.Query.Model;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Projects.Query.Request
{
    public class GetProjectByYearQuery : IRequest<Result<ICollection<ProjectModel>>>
    {
        public GetProjectByYearQuery(int year)
        {
            this.Year = year;
        }
        public int Year { get; }
    }
}
