using System.Net;
using Graduation_Project_Store.API.Bases;
using GraduationProjecrStore.Infrastructure.Persistence.Context;
using GraduationProjectStore.Core.Feature.Projects.Query.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Graduation_Project_Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaginationController :  Base
    {
        private readonly AppDbContext _context;
        public PaginationController(AppDbContext context)
        {
            this._context = context;
        }

        [HttpGet("paginate/page/pageSize")]
        public async Task<IActionResult> Paginate(int page = 1, int pageSize = 10)
        {
            if (page <= 0) page = 1;
            if (pageSize <= 0) pageSize = 10;

            int totalProjects =  _context.Projects.Count();
            var totalPages = (int)Math.Ceiling(totalProjects / (double)pageSize);

            var projects = await _context.Projects
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return Ok(new
            {
                Page = page,
                PageSize = pageSize,
                TotalPages = totalPages,
                TotalItems = totalProjects,
                Data = projects
            });
        }

        [HttpGet("Get/Year")]
        public async Task<IActionResult> GetByYear(int Year)
        {
            var getByYear = await Mediator.Send(new GetProjectByYearQuery(Year));
            return HandledResult(getByYear);
        }

        [HttpGet("Get/Department")]
        public async Task<IActionResult> GetByDepartment(int id)
        {
            var getBydepartment = await Mediator.Send(new GetProjectByDepartmentQuery(id));
            return HandledResult(getBydepartment);
        }

        [HttpGet("Get/College")]
        public IActionResult GetByCollege(int id)
        {
           if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var projects = _context.Projects.Where(x=>x.CollegeId == id);
            
            return projects.Any()
                ? Ok( new 
                {
                    Data = projects,
                    StatusCode = HttpStatusCode.OK,
                    NumOfProjects = projects.Count(),
                })
                : NotFound($"No projects found for college with ID {id}.");
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var getAllCommand = await Mediator.Send(new GetAllProjectQuery());
            return HandledResult(getAllCommand);
        }
    }
}
