using AutoMapper;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjectStore.Core.Feature.Students.Query.Model;

namespace GraduationProjectStore.Core.Mapping.Students
{
    public partial class StudentProfile 
    {
        public void GetStudentQueryMaooing()
        {
            CreateMap<StudentModel, Student>().
               ForMember(x => x.Id, x => x.MapFrom(x => x.Student_Id)).
               ForMember(x => x.SupervisorId, x => x.MapFrom(x => x.Student_SupervisorId)).
               ForMember(x => x.DepartmentId, x => x.MapFrom(x => x.Student_DepartmentId)).
               ForMember(x => x.ProjectId, x => x.MapFrom(x => x.Student_ProjectId)).
               ForMember(x => x.Level, x => x.MapFrom(x => x.Student_ProjectId)).
               ForMember(x => x.BirthDate, x => x.MapFrom(x => x.Student_BirthDate)).
               ForMember(x => x.FirstName, x => x.MapFrom(x => x.Student_FName)).
               ForMember(x => x.LastName, x => x.MapFrom(x => x.Student_LName)).
               ForMember(x => x.Address, x => x.MapFrom(x => x.Student_Address)).
               ForMember(x => x.GPA, x => x.MapFrom(x => x.Student_GPA)).ReverseMap();
        }
    }
}
