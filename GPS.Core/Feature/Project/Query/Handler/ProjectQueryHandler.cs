using AutoMapper;
using GraduationProjectStore.Core.Feature.Projects.Query.Model;
using GraduationProjectStore.Core.Feature.Projects.Query.Request;
using GraduationProjectStore.Core.ResultHandlers;
using GraduationProjectStore.Service.UnitOfWorks;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Projects.Query.Handler
{
    public class ProjectQueryHandler
        : ResultHandler,
        IRequestHandler<GetProjectByIdQuery, Result<ProjectModel>> ,
        IRequestHandler<GetAllProjectQuery, Result<ICollection<ProjectModel>>> ,
        IRequestHandler<GetProjectByYearQuery, Result<ICollection<ProjectModel>>>,
        IRequestHandler<GetProjectByDepartmentQuery, Result<ICollection<ProjectModel>>>,
        IRequestHandler<GetProjectBySupervisorQuery, Result<ICollection<ProjectModel>>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _service;

        public ProjectQueryHandler(IUnitOfWork service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Result<ICollection<ProjectModel>>> Handle
            (GetAllProjectQuery request, CancellationToken cancellationToken)
        {
            var projects = await _service.ProjectService.GetAll();
            if (projects == null)
                return NotFound<ICollection<ProjectModel>>(_message:"Faculty Not Has Any Project");

            var projectMapped = _mapper.Map<ICollection<ProjectModel>>(projects);
            return OK<ICollection<ProjectModel>>(_data: projectMapped);
        }

        public async Task<Result<ProjectModel>> Handle
            (GetProjectByIdQuery request, CancellationToken cancellationToken)
        {
           if(request.Id <= 0)
                return NotFound<ProjectModel>(_message: "Invalid Project Id");

            var project = await _service.ProjectService.GetOne(request.Id);
            if(project == null)
                return NotFound<ProjectModel>(_message: "Project Not Found Or Invalid Project Id");

            var projectMapped = _mapper.Map<ProjectModel>(project);  
            return OK<ProjectModel>(_data: projectMapped);  
        }

        public async Task<Result<ICollection<ProjectModel>>> Handle
            (GetProjectByYearQuery request, CancellationToken cancellationToken)
        {
            if (request.Year <= 0)
                return NotFound<ICollection<ProjectModel>>(_message: "Invalid Yaer");

            var project = await _service.ProjectService.GetByYear(request.Year);
            var projectsModel = _mapper.Map<ICollection<ProjectModel>>(project);

            return projectsModel.Count() > 0 ? 
                OK<ICollection<ProjectModel>>(_data: projectsModel,_message:$"Department Has = {projectsModel.Count()}") : 
                NotFound<ICollection<ProjectModel>>(_message: "No Project Found In This Year");
        }

        public async Task<Result<ICollection<ProjectModel>>> Handle
            (GetProjectByDepartmentQuery request, CancellationToken cancellationToken)
        {
            if (request.DepartmentId <= 0)
                return NotFound<ICollection<ProjectModel>>(_message: "Invalid Department Id");

            var project = await _service.ProjectService.GetByDepartment(request.DepartmentId);
            var projectsModel = _mapper.Map<ICollection<ProjectModel>>(project);

            return projectsModel.Count() > 0 ?
                OK<ICollection<ProjectModel>>(_data: projectsModel, _message: $"Department Has = {projectsModel.Count()}") :
                NotFound<ICollection<ProjectModel>>(_message: "No Project Found In This Year");
        }

        public async Task<Result<ICollection<ProjectModel>>> Handle
            (GetProjectBySupervisorQuery request, CancellationToken cancellationToken)
        {
            if (request.SupervisorId <= 0)
                return NotFound<ICollection<ProjectModel>>(_message: "Invalid Suoervisor Id");

            var project = await _service.ProjectService.GetBySupervisor(request.SupervisorId);
            var projectsModel = _mapper.Map<ICollection<ProjectModel>>(project);

            return projectsModel.Count() > 0 ?
                OK<ICollection<ProjectModel>>(_data: projectsModel, _message: $"Department Has = {projectsModel.Count()}") :
                NotFound<ICollection<ProjectModel>>(_message: "No Project Found In This Year");
        }
    }
}
