using AutoMapper;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjectStore.Core.Feature.Departments.Command.Request;
using GraduationProjectStore.Core.ResultHandlers;
using GraduationProjectStore.Service.UnitOfWorks;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Departments.Command.Handler
{
    public class DepartmentCommandHandler
        : ResultHandler,
        IRequestHandler<CreateDepartmentCommand, Result<string>>,
        IRequestHandler<UpdateDepartmentCommand, Result<string>>,
        IRequestHandler<DeleteDepartmentCommand, Result<string>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _service;

        public DepartmentCommandHandler(IMapper mapper, IUnitOfWork service)
        {
            _mapper = mapper;
            _service = service;
        }

        public async Task<Result<string>> Handle
            (CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            if (request.Department == null)
                return BadRequest<string>(_message: "Invaild Department Data");

            var departmentMapped = _mapper.Map<Department>(request.Department);
            var createResult = await _service.DepartmentService.CreateAsync(departmentMapped);

            return createResult == "Successfully" ?
                Created<string>(_message: "Department Created Successfully") :
                BadRequest<string>(_message: "Invalid Creation");
        }

        public async Task<Result<string>> Handle
            (UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            if (request.Department == null)
                return BadRequest<string>(_message: "Invaild Department Data");

            var departmentMapped = _mapper.Map<Department>(request.Department);
            var updatingResult = await _service.DepartmentService.
                UpdateAsync(departmentMapped, request.Department.deparId);

            if (updatingResult == "NotFound")
                return NotFound<string>(_message: "Department Not Found");

            return updatingResult == "Successfully" ?
                OK<string>(_message: "Department Updated Successfully") :
                BadRequest<string>(_message: "Invalid Updating");
        }

        public async Task<Result<string>> Handle
            (DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            if (request.Id <= 0)
                return BadRequest<string>(_message: "Invaild Department Number");

            var deletingResult = await _service.DepartmentService.
                DeleteAsync(request.Id);

            if(deletingResult =="NotFound")
                return NotFound<string>(_message: "Department Not Found");

            return deletingResult == "Successfully" ?
                OK<string>(_message: "Department Deleted Successfully") :
                BadRequest<string>(_message: "Invalid Deleting");
        }
    }
}
