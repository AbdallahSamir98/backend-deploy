using Graduation_Project_Store.API.Bases;
using GraduationProjectStore.Core.Feature.Projects;
using GraduationProjectStore.Core.Feature.Projects.Command.Request;
using GraduationProjectStore.Core.Feature.Projects.Query.Request;
using Microsoft.AspNetCore.Mvc;

namespace Graduation_Project_Store.API.Controllers
{
    [ApiController]
    [Route("api/project")]
    public class ProjectController : Base
    {
       [HttpPost("Create")]
public async Task<IActionResult> Create([FromForm] CreateProjectDTO project)
{
    var createCommand = await Mediator.Send(new CreateProjectCommand(project));
    return HandledResult(createCommand);
}


        [HttpGet("Get/ById")]
        public async Task<IActionResult> Get(int id)
        {
            var getCommand = await Mediator.Send(new GetProjectByIdQuery(id));
            return HandledResult(getCommand);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateProjectDTO project)
        {
            var updateCommand = await Mediator.Send(new UpdateProjectCommand(project));
            return HandledResult(updateCommand);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteCommand = await Mediator.Send(new DeleteProjectCommand(id));
            return HandledResult(deleteCommand);
        }
    }
}
