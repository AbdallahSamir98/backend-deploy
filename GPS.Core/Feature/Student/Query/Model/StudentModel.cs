using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProjectStore.Core.Feature.Students.Query.Model
{
    public class StudentModel
    {
        public int Student_Id {set;get;}
        public string Student_FName { get; }
        public string Student_LName { get; }
        public string Student_Address { get; }
        public DateTime Student_BirthDate { set; get; }
        public double Student_GPA { get; }
        public int Student_Level { get; }
        public int Student_DepartmentId { get; }
        public int Student_ProjectId { get; }
        public int Student_SupervisorId { get; }
    }
}
