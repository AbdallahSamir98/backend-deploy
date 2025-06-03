using AutoMapper;
using GraduationProjecrStore.Infrastructure.Domain.DTOs.Student;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;

namespace GraduationProjectStore.Core.Mapping.Students
{
    public partial class StudentProfile 
    {
        public void CreateStudentCommandMapping()
        {
            CreateMap<Student, CreateStudentDTO>().
                ForMember(x => x.Student_SupervisorId, x => x.MapFrom(x => x.SupervisorId)).
                ForMember(x => x.Student_DepartmentId, x => x.MapFrom(x => x.DepartmentId)).
                ForMember(x => x.Student_ProjectId, x => x.MapFrom(x => x.ProjectId)).
                ForMember(x => x.Student_Level, x => x.MapFrom(x => x.Level)).
                ForMember(x => x.Student_BirthDate, x => x.MapFrom(x => x.BirthDate)).
                ForMember(x => x.Student_FName, x => x.MapFrom(x => x.FirstName)).
                ForMember(x => x.Student_LName, x => x.MapFrom(x => x.LastName)).
                ForMember(x => x.Student_Address, x => x.MapFrom(x => x.Address)).
                ForMember(x => x.Student_GPA, x => x.MapFrom(x => x.GPA)).ReverseMap();
        }

        public void UpdateStudentCommandMapping()
        {
            CreateMap<Student, UpdateStudentDTO>().
               ForMember(x => x.Student_Id, x => x.MapFrom(x => x.Id)).
               ForMember(x => x.Student_SupervisorId, x => x.MapFrom(x => x.SupervisorId)).
               ForMember(x => x.Student_DepartmentId, x => x.MapFrom(x => x.DepartmentId)).
               ForMember(x => x.Student_ProjectId, x => x.MapFrom(x => x.ProjectId)).
               ForMember(x => x.Student_Level, x => x.MapFrom(x => x.Level)).
               ForMember(x => x.Student_FBirthDate, x => x.MapFrom(x => x.BirthDate)).
               ForMember(x => x.Student_FName, x => x.MapFrom(x => x.FirstName)).
               ForMember(x => x.Student_LName, x => x.MapFrom(x => x.LastName)).
               ForMember(x => x.Student_Address, x => x.MapFrom(x => x.Address)).
               ForMember(x => x.Student_GPA, x => x.MapFrom(x => x.GPA)).ReverseMap();
        }
    }
}
