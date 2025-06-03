using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjectStore.Core.Feature.Departments.Query.Models;
using GraduationProjectStore.Core.Feature.Departments.Query.Request;
using GraduationProjectStore.Core.ResultHandlers;
using GraduationProjectStore.Service.UnitOfWorks;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Departments.Query.Handler
{
    public class DepartmentQueryHandler :
        ResultHandler,
        IRequestHandler<GetDepartmentByIdQuery,Result<DepartmentModel>> ,
        IRequestHandler<GetAllDepartmetsQuery, Result<ICollection<DepartmentModel>>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _service;

        public DepartmentQueryHandler(IUnitOfWork service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Result<ICollection<DepartmentModel>>> Handle
            (GetAllDepartmetsQuery request, CancellationToken cancellationToken)
        {
            var departments = await _service.DepartmentService.GetAll();

            if (departments == null)
                return NotFound<ICollection<DepartmentModel>>
                        (_message:"Department List Is Empty");

            var departmentMapped = _mapper.
                Map<ICollection<DepartmentModel>>(departments);
            return OK<ICollection<DepartmentModel>>
                (_data:departmentMapped,_meta:$"Department Count = {departmentMapped.Count()}");
        }

        public async Task<Result<DepartmentModel>> Handle
            (GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var department = await _service.DepartmentService.GetOne(request.Id);
            if (department == null)
                return NotFound<DepartmentModel>
                        (_message: "Department Not Found Or Invalid Department Number");

            var departmentMapped = _mapper.
               Map<DepartmentModel>(department);
            return OK<DepartmentModel>(_data:departmentMapped);
        }
    }
}
