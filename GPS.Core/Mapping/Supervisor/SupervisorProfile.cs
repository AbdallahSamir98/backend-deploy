using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace GraduationProjectStore.Core.Mapping.Supervisors
{
    public partial class SupervisorProfile : Profile
    {
        public SupervisorProfile()
        {
            GetSupervisorQueryMapping();
            CreateSupervisorCommandMapping();
            UpdateSupervisorCommandMapping();
        }
    }
}
