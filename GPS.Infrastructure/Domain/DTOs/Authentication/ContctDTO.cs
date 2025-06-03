namespace GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication
{
    public class ContctDTO
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Message { set; get; }
        public Guid UserId { set; get; }
    }
}
