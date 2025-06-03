using Graduation_Project_Store.API.Bases;
using GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication;
using GraduationProjectStore.Service.UnitOfWorks;
using Microsoft.AspNetCore.Mvc;

namespace Graduation_Project_Store.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ContactController : Base
    {
        private readonly IUnitOfWork unitOfWork;

        public ContactController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpPost("Start")]
        public async Task<IActionResult> StartContact(ContctDTO contact)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.ErrorCount);
             
            var sendOperation = await unitOfWork.ContactService.StartContactAsync(contact);
            return sendOperation == "Successfully" ?
                Ok("Inquire Are Send Succssfully") :
                sendOperation == "UserNotFound" ?
                NotFound("User Not Found") :
                BadRequest(sendOperation);
        }
    }
}
