using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace GraduationProjectStore.Core.Mapping.Projects
{
    public partial class ProjectProfile : Profile
    {
        public ProjectProfile() 
        {
            GetProjectsQueryMapping();
            UpdateProjectCommandMapping();
            CreateProjectCommandMapping();
        }
    }
}
