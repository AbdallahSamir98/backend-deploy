namespace GraduationProjecrStore.Infrastructure.Domain.DTOs.Student
{
    public class UpdateStudentDTO
    {
        public int Student_Id { set; get; } 
        public string Student_FName { set; get; }
        public string Student_LName { set; get; }
        public string Student_Address { set; get; }
        public DateTime Student_FBirthDate { set; get; }
        public double Student_GPA { set; get; }
        public int Student_Level { set; get; }
        public int Student_DepartmentId { set; get; }
        public int Student_ProjectId { set; get; }
        public int Student_SupervisorId { set; get; }
    }
}
