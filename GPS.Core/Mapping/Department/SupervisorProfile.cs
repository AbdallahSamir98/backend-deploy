using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace GraduationProjectStore.Core.Mapping.Departments
{
    public partial class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            GetDepartmentQueryMappping();
            CreateDepartmentCommandMapping();
            UpdateDepartmentCommandMapping();
        }
    }
}
