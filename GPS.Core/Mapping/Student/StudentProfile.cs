using AutoMapper;

namespace GraduationProjectStore.Core.Mapping.Students
{
    public partial class StudentProfile : Profile
    {
        public StudentProfile()
        {
            GetStudentQueryMaooing();
            UpdateStudentCommandMapping();
            CreateStudentCommandMapping();
        }
    }
}
