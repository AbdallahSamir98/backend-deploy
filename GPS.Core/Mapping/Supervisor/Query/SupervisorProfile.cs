using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjecrStore.Infrastructure.Domain.DTOs.Supervisor;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjectStore.Core.Feature.Supervisors.Query.Model;

namespace GraduationProjectStore.Core.Mapping.Supervisors
{
    public partial class SupervisorProfile
    {
        public void GetSupervisorQueryMapping()
        {
            CreateMap<SupervisorModel, Supervisor>().
                ForMember(x => x.Id, x => x.MapFrom(x => x.Supervisor_Number)).
                ForMember(x => x.FirstName, x => x.MapFrom(x => x.Supervisor_FName)).
                ForMember(x => x.LastName, x => x.MapFrom(x => x.Supervisor_LName)).
                ForMember(x => x.Position, x => x.MapFrom(x => x.Supervisor_Position)).
                ForMember(x => x.DepartmentId, x => x.MapFrom(x => x.Supervisor_DepartmentId)).ReverseMap();
        }
    }
}
