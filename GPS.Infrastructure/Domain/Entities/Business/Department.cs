using GraduationProjecrStore.Infrastructure.Domain.Entities.Business.Common;

namespace GraduationProjecrStore.Infrastructure.Domain.Entities.Business
{
    public sealed class Department : TableIdentity
    {
        public string Manager { set; get; }
        public ICollection<Student> Students { set; get; } = new List<Student>();
        public ICollection<Supervisor> Supervisors { set; get; } = new List<Supervisor>();
        public ICollection<Project> Projects { set; get; } = new List<Project>();
    }
}
