using GraduationProjecrStore.Infrastructure.Domain.Entities.Business.Common;

namespace GraduationProjecrStore.Infrastructure.Domain.Entities.Business
{
    public sealed class Student : TableIdentity
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Address { set; get; }
        public DateTime BirthDate { set; get; }
        public double GPA { set; get; }
        public int Level { set; get; }
        public Department Department { set; get; }
        public int DepartmentId { set; get; }   
        public Project? Project { set; get; }    
        public int ?ProjectId { set; get; }
        public Supervisor Supervisor { set; get; }
        public int SupervisorId { set; get; }
    }
}


