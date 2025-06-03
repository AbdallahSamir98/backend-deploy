using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjecrStore.Infrastructure.Domain.DTOs.Supervisor;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;

namespace GraduationProjectStore.Core.Mapping.Supervisors
{
    public partial class SupervisorProfile
    {
        public void CreateSupervisorCommandMapping()
        {
            CreateMap<Supervisor, CreateSupervisorDTO>()
                .ForMember(x => x.FirstName, x => x.MapFrom(x => x.FirstName))
                .ForMember(x => x.LastName, x => x.MapFrom(x => x.LastName))
                .ForMember(x => x.Position, x => x.MapFrom(x => x.Position))
                .ForMember(x => x.DepartmentId, x => x.MapFrom(x => x.DepartmentId))
                .ForMember(x => x.Address, x => x.MapFrom(x => x.Address)).ReverseMap();
        }

        public void UpdateSupervisorCommandMapping()
        {
            CreateMap<Supervisor, UpdateSupervisorDTO>()
               .ForMember(x => x.Id, x => x.MapFrom(x => x.Id))
               .ForMember(x => x.FirstName, x => x.MapFrom(x => x.FirstName))
               .ForMember(x => x.LastName, x => x.MapFrom(x => x.LastName))
               .ForMember(x => x.Position, x => x.MapFrom(x => x.Position))
               .ForMember(x => x.DepartmentId, x => x.MapFrom(x => x.DepartmentId))
               .ForMember(x => x.Address, x => x.MapFrom(x => x.Address)).ReverseMap();
        }
    }
}
