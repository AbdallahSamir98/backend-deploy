using GraduationProjectStore.Core.Feature.Supervisors.Query.Model;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Supervisors.Query.Request
{
    public class GetSupervisorByIdQuery : IRequest<Result<SupervisorModel>>
    {
        public GetSupervisorByIdQuery(int id)
        {
            this.Id = id;
        }

        public int Id { set; get; }
    }   
}
