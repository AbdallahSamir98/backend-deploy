using GraduationProjecrStore.Infrastructure.Domain.Entities.Business.Common;
using Microsoft.Identity.Client;

namespace GraduationProjecrStore.Infrastructure.Domain.Entities.Business
{
    public sealed class Supervisor : TableIdentity 
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Position { set; get; }    
        public string Address { set; get; }
        public DateTime BirthDate { set; get; }
        public int DepartmentId { set; get; }
        public Department Department { set; get; }
        public ICollection<Student> Students { set; get; } = new List<Student>();
        public ICollection<Project> Projects { set; get; } = new List<Project>();
    }
}
