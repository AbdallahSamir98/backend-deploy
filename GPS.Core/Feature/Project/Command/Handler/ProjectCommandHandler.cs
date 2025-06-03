using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjectStore.Core.Feature.Projects.Command.Request;
using GraduationProjectStore.Core.ResultHandlers;
using GraduationProjectStore.Service.UnitOfWorks;
using MediatR;
using static System.Net.Mime.MediaTypeNames;

namespace GraduationProjectStore.Core.Feature.Projects.Command.Handler
{
    public class ProjectCommandHandler :
        ResultHandler,
        IRequestHandler<CreateProjectCommand, Result<string>> ,
        IRequestHandler<UpdateProjectCommand, Result<string>> ,
        IRequestHandler<DeleteProjectCommand, Result<string>> 

    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _service;

        public ProjectCommandHandler(IUnitOfWork service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Result<string>> Handle
            (CreateProjectCommand request, CancellationToken cancellationToken)
        {
            if (request.projectDTO == null)
                return BadRequest<string>(_message:"Invalid Project Data");

            var _project = new Project();
            using (var memoryStream = new MemoryStream())
            {
                await request.projectDTO.projectFile.CopyToAsync(memoryStream);
                _project.Name = request.projectDTO.projectFile.Name;
                _project.Data = memoryStream.ToArray();
                _project.ContentType = request.projectDTO.projectFile.ContentType;
                _project.DepartmentId = request.projectDTO.DepartmentId;
                _project.SupervisorId = request.projectDTO.SupervisorId;
                    _project.CollegeId = request.projectDTO.CollegeId; // ✅ هذا السطر يحل المشكلة

                _project.UploadAt = DateTime.UtcNow;
                _project.Description = request.projectDTO.Description;
            }

            var createOperation = await _service.ProjectService.CreateAsync(_project);

            return createOperation == "Successfully" ? 
                OK<string>(_message: "Project Created Successfully") : 
                BadRequest<string>(_message: "Project Creation Failed");  
        }

        public async Task<Result<string>> Handle
            (UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            if (request.projectDTO == null)
                return BadRequest<string>(_message: "Invalid Project Data");

            var project = _mapper.Map<Project>(request.projectDTO);
            var updateOperation = await _service.ProjectService
                .UpdateAsync(project,request.projectDTO.Id);

            if (updateOperation == "NotFound")
                return NotFound<string>(_message:"Project Not Found Or Invalid Project Id");

            return updateOperation == "Successfully" ?
                OK<string>(_message: "Project Updated Successfully") :
                BadRequest<string>(_message: "Project Update Failed");
        }

        public async Task<Result<string>> Handle
            (DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            if (request.Id <= 0)
                return BadRequest<string>(_message: "Invalid Project Id");

            var deleteOperation = await _service.ProjectService.DeleteAsync(request.Id);
            if (deleteOperation == "NotFound")
                return NotFound<string>(_message: "Project Not Found Or Invalid Project Id");

            return deleteOperation == "Successfully" ?
                OK<string>(_message: "Project Deleted Successfully") :
                BadRequest<string>(_message: "Project Delete Failed");
        }
    }
}
