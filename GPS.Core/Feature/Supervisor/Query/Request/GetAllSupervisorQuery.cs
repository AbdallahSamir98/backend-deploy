using GraduationProjectStore.Core.Feature.Supervisors.Query.Model;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Supervisors.Query.Request
{
    public class GetAllSupervisorQuery : IRequest<Result<ICollection<SupervisorModel>>>
    {

    }
}
