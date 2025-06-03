using GraduationProjecrStore.Infrastructure.Domain.DTOs;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjectStore.Core.Feature.Departments.Query.Models;

namespace GraduationProjectStore.Core.Mapping.Departments
{
    public partial class DepartmentProfile
    {
        public void GetDepartmentQueryMappping()
        {
            CreateMap<DepartmentModel,Department >()
                .ForMember(x => x.Id, x => x.MapFrom(x => x.Dept_Id))
                .ForMember(x => x.Name, x => x.MapFrom(x => x.Dept_Name))
                .ForMember(x => x.Manager, x => x.MapFrom(x => x.Dept_Manager)).ReverseMap();
        }
    }
}
