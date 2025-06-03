using AutoMapper;
using GraduationProjectStore.Core.Feature.Supervisors.Query.Model;
using GraduationProjectStore.Core.Feature.Supervisors.Query.Request;
using GraduationProjectStore.Core.ResultHandlers;
using GraduationProjectStore.Service.UnitOfWorks;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Supervisors.Query.Handler
{
    public class SupervisorQueryHandler
        : ResultHandler,
        IRequestHandler<GetSupervisorByIdQuery, Result<SupervisorModel>>,   
        IRequestHandler<GetAllSupervisorQuery, Result<ICollection<SupervisorModel>>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _service;
        public SupervisorQueryHandler(IUnitOfWork service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Result<ICollection<SupervisorModel>>> Handle
            (GetAllSupervisorQuery request, CancellationToken cancellationToken)
        {
            var supervisors = await _service.SupervisorService.GetAll();
            if (supervisors == null)
                return NotFound<ICollection<SupervisorModel>>(_message:"Supervosir List Is Empty");

            var supervisorsMapped = _mapper.Map<ICollection<SupervisorModel>>(supervisors);
            return OK<ICollection<SupervisorModel>>
                (_data:supervisorsMapped,_meta:$"Faculty Has {supervisorsMapped.Count()} Supervisor");
        }

        public async Task<Result<SupervisorModel>> Handle
            (GetSupervisorByIdQuery request, CancellationToken cancellationToken)
        {
            if (request.Id <= 0)
                return NotFound<SupervisorModel>(_message:"Supervosir Number Invalid");

            var supervisor = await _service.SupervisorService.GetOne(request.Id);
            if (supervisor == null)
                return NotFound<SupervisorModel>(_message: "Supervosir Not Found");

            var supervisorMapped = _mapper.Map<SupervisorModel>(supervisor);
            return OK<SupervisorModel>(_data: supervisorMapped);
        }
    }
}
