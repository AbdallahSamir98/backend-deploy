using Graduation_Project_Store.API.Bases;
using GraduationProjecrStore.Infrastructure.Domain.DTOs.Department;
using GraduationProjectStore.Core.Feature.Departments.Command.Request;
using GraduationProjectStore.Core.Feature.Departments.Query.Request;
using Microsoft.AspNetCore.Mvc;

namespace Graduation_Project_Store.API.Controllers
{
    [ApiController]
    [Route("api/department")]
    public class DepartmentController : Base
    {
        [HttpPost("Create")]
        public async Task<IActionResult>Create(DepartmentDTO department)
        {
            var createCommand = await Mediator.Send(new CreateDepartmentCommand(department));
            return HandledResult(createCommand);
        }

        [HttpGet("Get{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            var getOneQuery = await Mediator.Send(new GetDepartmentByIdQuery(id));
            return HandledResult(getOneQuery);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll( )
        {
            var getAllQuery = await Mediator.Send(new GetAllDepartmetsQuery()); 
            return HandledResult(getAllQuery);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateDepartmentDTO department)
        {
            var updateCommand = await Mediator.Send(new UpdateDepartmentCommand(department));
            return HandledResult(updateCommand);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteCommand = await Mediator.Send(new DeleteDepartmentCommand(id));
            return HandledResult(deleteCommand);
        }
    }
}
