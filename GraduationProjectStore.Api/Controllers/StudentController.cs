using Graduation_Project_Store.API.Bases;
using GraduationProjecrStore.Infrastructure.Domain.DTOs.Student;
using GraduationProjectStore.Core.Feature.Students.Command.Requsst;
using GraduationProjectStore.Core.Feature.Students.Query.Request;
using Microsoft.AspNetCore.Mvc;

namespace Graduation_Project_Store.API.Controllers
{
    [ApiController]
    [Route("api/student")]
    public class StudentController : Base
    {
        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateStudentDTO student)
        {
            var createCommand = await Mediator.Send(new CreateStudentCommand(student));
            return HandledResult(createCommand);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var getCommand = await Mediator.Send(new GetStudentByIdQuery(id));
            return HandledResult(getCommand);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var getAllCommand = await Mediator.Send(new GetAllStudentQuery());
            return HandledResult(getAllCommand);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateStudentDTO student)
        {
            var updateCommand = await Mediator.Send(new UpdateStudentCommand(student));
            return HandledResult(updateCommand);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteCommand = await Mediator.Send(new DeleteStudentCommand(id));
            return HandledResult(deleteCommand);
        }
    }
}
