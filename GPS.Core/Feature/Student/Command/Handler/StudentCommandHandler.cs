using AutoMapper;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjectStore.Core.Feature.Students.Command.Requsst;
using GraduationProjectStore.Core.ResultHandlers;
using GraduationProjectStore.Service.UnitOfWorks;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Students.Command.Handler
{
    public class StudentCommandHandler
        : ResultHandler,
        IRequestHandler<CreateStudentCommand, Result<string>> , 
        IRequestHandler<UpdateStudentCommand, Result<string>> , 
        IRequestHandler<DeleteStudentCommand, Result<string>> 
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _service;
        public StudentCommandHandler(IUnitOfWork service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Result<string>> Handle
            (CreateStudentCommand request, CancellationToken cancellationToken)
        {
            if (request.Student == null)
                return BadRequest<string>(_message:"Invalid Student Data");

            var studentMapped = _mapper.Map<Student>(request.Student);
            var createOperation = await _service.StudentService.CreateAsync(studentMapped);

            return createOperation == "Successfully" ? OK<string>(_message:"Student Added Successfully")
                : BadRequest<string>(_message:"Failed Added");
        }

        public async Task<Result<string>> Handle
            (UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            if (request.Student == null)
                return BadRequest<string>(_message: "Invalid Student Data");

            var studentMapped = _mapper.Map<Student>(request.Student);
            var updateOperation = await _service.StudentService.
                UpdateAsync(studentMapped,request.Student.Student_Id);

            if (updateOperation == "NotFound")
                return NotFound<string>(_message:"Student Not Found");

            return updateOperation == "Successfully" ? OK<string>(_message: "Student Updated Successfully")
               : BadRequest<string>(_message: "Failed Update"); 
        }

        public async Task<Result<string>> Handle
            (DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            if (request.Id <=0)
                return BadRequest<string>(_message: "Invalid Student Number");

            var deleteOperation = await _service.StudentService.DeleteAsync(request.Id);
            if (deleteOperation == "NotFound")
                return NotFound<string>(_message: "Student Not Found");

            return deleteOperation == "Successfully" ? OK<string>(_message: "Student Deleted Successfully")
              : BadRequest<string>(_message: "Failed Delete");
        }
    }
}
