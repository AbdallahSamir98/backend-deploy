using AutoMapper;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjectStore.Core.Feature.Supervisors.Command.Request;
using GraduationProjectStore.Core.ResultHandlers;
using GraduationProjectStore.Service.Implementation.Security;
using GraduationProjectStore.Service.UnitOfWorks;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Supervisors.Command.Handler
{
    public class SupervisorCommandHandler
        : ResultHandler,
        IRequestHandler<CreateSupervisorCommand, Result<string>>,
        IRequestHandler<DeleteSupervisorCommand, Result<string>> ,
        IRequestHandler<UpdateSupervisorCommand, Result<string>> 
    {
        private readonly IUnitOfWork _service;
        private readonly IMapper _mapper;

        public SupervisorCommandHandler(IUnitOfWork service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<Result<string>> Handle
            (CreateSupervisorCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                return BadRequest<string>(_message: "Invalid Supervisor Date");

            var supervisorMapped = _mapper.Map<Supervisor>(request.Supervisor);
            var createResult = await _service.SupervisorService.CreateAsync(supervisorMapped);

            return createResult == "Successfully" ? Created<string>(_message: "Created Successfully")
                : BadRequest<string>(_message: "Invalid");
        }

        public async Task<Result<string>> Handle
            (DeleteSupervisorCommand request, CancellationToken cancellationToken)
        {
            if (request.Id <= 0)
                return BadRequest<string>(_message:"Invalid Supervisor Number");

            var deleteResult = await _service.SupervisorService.DeleteAsync(request.Id);
            if (deleteResult == "NotFound")
                return NotFound<string>(_message:"Supervisor Not Found Or Invalid Supervisor Number");

            return deleteResult == "Successfully" ? OK<string>(_message: "Deleted Successfully")
                : BadRequest<string>(_message: "Invalid");
        }

        public async Task<Result<string>> Handle
            (UpdateSupervisorCommand request, CancellationToken cancellationToken)
          {
            if (request.supervisor == null)
                return BadRequest<string>(_message: "Invalid Supervisor Data");

            var SupervisorMapped = _mapper.Map<Supervisor>(request.supervisor);
            var updateResult = await _service.SupervisorService.
                UpdateAsync(SupervisorMapped,request.supervisor.Id);

            if (updateResult == "NotFound")
                return NotFound<string>(_message:"Supervisor Not Found");

            return updateResult == "Successfully" ? OK<string>(_message: "Updated Successfully")
                : BadRequest<string>(_message: "Invalid");
        }
    }
}
