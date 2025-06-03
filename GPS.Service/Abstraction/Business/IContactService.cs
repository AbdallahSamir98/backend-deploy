using GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjecrStore.Infrastructure.Repository;

namespace GraduationProjectStore.Service.Abstraction.Business
{
    public interface IContactService : IMainRepository<Contact>
    {
        ValueTask<string> StartContactAsync(ContctDTO contact);
    }
}
