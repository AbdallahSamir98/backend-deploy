using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjectStore.Core.Feature.Projects;

namespace GraduationProjectStore.Core.Mapping.Projects
{
    public partial class ProjectProfile
    {
        public void UpdateProjectCommandMapping()
        {
            CreateMap<Project, UpdateProjectDTO>()
               .ForMember(x => x.Id, x => x.MapFrom(x => x.Id))
               .ForMember(x => x.CollegeId, x => x.MapFrom(x => x.CollegeId))
               .ForMember(x => x.SupervisorId, x => x.MapFrom(x => x.SupervisorId))
               .ForMember(x => x.DepartmentId, x => x.MapFrom(x => x.DepartmentId))
               .ForMember(x => x.Description, x => x.MapFrom(x => x.Description))
               .ForMember(x => x.UploadAt, x => x.MapFrom(x => x.UploadAt))
               // for path becuse it nested property
               .ForPath(x => x.projectFile.FileName, x => x.MapFrom(x => x.Name))
               .ForPath(x => x.projectFile.ContentType, x => x.MapFrom(x => x.ContentType));
        }

        public void CreateProjectCommandMapping()
        {
            CreateMap<Project, CreateProjectDTO>()
               .ForMember(x => x.CollegeId, x => x.MapFrom(x => x.CollegeId))
               .ForMember(x => x.SupervisorId, x => x.MapFrom(x => x.SupervisorId))
               .ForMember(x => x.DepartmentId, x => x.MapFrom(x => x.DepartmentId))
               .ForMember(x => x.Description, x => x.MapFrom(x => x.Description))
               .ForPath(x => x.projectFile.FileName, x => x.MapFrom(x => x.Name))
               .ForPath(x => x.projectFile.ContentType, x => x.MapFrom(x => x.ContentType));
        }

    }
}
