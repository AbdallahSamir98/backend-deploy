using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjecrStore.Infrastructure.Domain.DTOs.Department;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Departments.Command.Request
{
    public class CreateDepartmentCommand : IRequest<Result<string>>
    {
        public CreateDepartmentCommand(DepartmentDTO department)
        {
            Department = department;
        }
        public DepartmentDTO Department { get; }
    }
}
