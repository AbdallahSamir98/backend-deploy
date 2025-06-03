using Graduation_Project_Store.API.Bases;
using GraduationProjecrStore.Infrastructure.Domain.DTOs.Supervisor;
using GraduationProjectStore.Core.Feature.Supervisors.Command.Request;
using GraduationProjectStore.Core.Feature.Supervisors.Query.Request;
using Microsoft.AspNetCore.Mvc;

namespace Graduation_Project_Store.API.Controllers
{
    [ApiController]
    [Route("api/supervisor")]
    public class SupervisorController : Base
    {
        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateSupervisorDTO supervisor)
        {
            var createCommand = await Mediator.Send(new CreateSupervisorCommand(supervisor));
            return HandledResult(createCommand);    
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var GetAllSupervisorQuery = await Mediator.Send(new GetAllSupervisorQuery());
            return HandledResult(GetAllSupervisorQuery);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Update(int id)
        {
            var GetOneQuery = await Mediator.Send(new GetSupervisorByIdQuery(id));
            return HandledResult(GetOneQuery);
        }

        [HttpPut("Update")]
        public async Task<IActionResult>Update(UpdateSupervisorDTO supervisor )
        {
            var updateCommand = await Mediator.Send(new UpdateSupervisorCommand(supervisor));
            return HandledResult(updateCommand);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteCommand = await Mediator.Send(new DeleteSupervisorCommand(id));
            return HandledResult(deleteCommand);
        }
    }
}
