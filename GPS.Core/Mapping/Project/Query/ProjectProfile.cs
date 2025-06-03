using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjectStore.Core.Feature.Projects.Query.Model;

namespace GraduationProjectStore.Core.Mapping.Projects
{
    public partial class ProjectProfile
    {
        public void GetProjectsQueryMapping()
        {
            CreateMap<Project, ProjectModel>()
               .ForMember(dest => dest.Project_Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Project_SupervisorId, opt => opt.MapFrom(src => src.SupervisorId))
               .ForMember(dest => dest.Project_DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
               .ForMember(dest => dest.Project_Description, opt => opt.MapFrom(src => src.Description))
               .ForMember(dest => dest.Project_UploadAt, opt => opt.MapFrom(src => src.UploadAt))
               .ForMember(dest => dest.Project_ContentType, opt => opt.MapFrom(src => src.ContentType))
               .ForMember(dest => dest.Project_Data, opt => opt.MapFrom(src => src.Data));
        }
    }
}
