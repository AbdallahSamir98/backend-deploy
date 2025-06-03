using GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjecrStore.Infrastructure.Persistence.Context;
using GraduationProjecrStore.Infrastructure.Repository;
using GraduationProjectStore.Service.Abstraction.Business;
using Microsoft.EntityFrameworkCore;

namespace GraduationProjectStore.Service.Implementation.Security
{
    public class ContactServive : MainRepository<Contact>, IContactService
    {
        private readonly AppDbContext _app;
        public ContactServive(AppDbContext app) : base(app)
        {
            this._app = app;
        }

        public async ValueTask<string> StartContactAsync(ContctDTO contact)
        {
           var user = await _app.Users.SingleOrDefaultAsync(x=>x.Id == contact.UserId);
            if (user == null)
                return "UserNotFound";

            var newContact = new Contact
            {
                Name = contact.Name,
                Email = contact.Email,
                PhoneNumber = contact.PhoneNumber,
                Message = contact.Message,
                UserId = contact.UserId
            };

            await _app.Contacts.AddAsync(newContact);
            var sendOperation = await _app.SaveChangesAsync();
            return sendOperation > 0 ? "Successfully" : 
                "Failed to send your message. Please try again later.";
        }
    }
}
