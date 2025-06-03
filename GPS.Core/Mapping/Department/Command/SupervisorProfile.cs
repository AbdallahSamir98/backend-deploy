using GraduationProjecrStore.Infrastructure.Domain.DTOs.Department;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;

namespace GraduationProjectStore.Core.Mapping.Departments
{
    public partial class DepartmentProfile
    {
        public void CreateDepartmentCommandMapping()
        {
            CreateMap<Department, DepartmentDTO>()
                .ForMember(x => x.depatName, x => x.MapFrom(x => x.Name))
                .ForMember(x => x.departManager, x => x.MapFrom(x => x.Manager)).ReverseMap();
        }

        public void UpdateDepartmentCommandMapping()
        {
            CreateMap<Department, UpdateDepartmentDTO>()
              .ForMember(x => x.deparId, x => x.MapFrom(x => x.Id))
              .ForMember(x => x.depatName, x => x.MapFrom(x => x.Name))
              .ForMember(x => x.departManager, x => x.MapFrom(x => x.Manager)).ReverseMap();
        }
    }
}
