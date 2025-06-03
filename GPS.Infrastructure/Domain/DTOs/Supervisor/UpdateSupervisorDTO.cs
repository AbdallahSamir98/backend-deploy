namespace GraduationProjecrStore.Infrastructure.Domain.DTOs.Supervisor
{
    public class UpdateSupervisorDTO
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Position { set; get; }
        public string Address { set; get; }
        public int DepartmentId { set; get; }
        public DateTime BirthDate { set; get; }
    }
}
