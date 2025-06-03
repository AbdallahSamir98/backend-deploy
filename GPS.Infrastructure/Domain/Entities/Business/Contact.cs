using GraduationProjecrStore.Infrastructure.Domain.Entities.Business.Common;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Security;

namespace GraduationProjecrStore.Infrastructure.Domain.Entities.Business
{
    public sealed class Contact : TableIdentity
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; } 
        public string Message { set; get; }
        public ApplicationUser User { set; get; }
        public Guid UserId { set; get; }
    }
}
