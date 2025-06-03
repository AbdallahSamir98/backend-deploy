using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjectStore.Core.Feature.Departments.Query.Models;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Departments.Query.Request
{
    public class GetDepartmentByIdQuery : IRequest<Result<DepartmentModel>>
    {
        public GetDepartmentByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; }
    }
}
