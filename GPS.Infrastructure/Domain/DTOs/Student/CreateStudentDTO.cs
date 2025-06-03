using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;

namespace GraduationProjecrStore.Infrastructure.Domain.DTOs.Student
{
    public class CreateStudentDTO
    {
        public string Student_FName { set; get; }
        public string Student_LName { set; get; }
        public string Student_Address { set; get; }
        public DateTime Student_BirthDate { set; get; }
        public double Student_GPA { set; get; }
        public int Student_Level { set; get; }
        public int Student_DepartmentId { set; get; }
        public int Student_ProjectId { set; get; }
        public int Student_SupervisorId { set; get; }
    }
}
