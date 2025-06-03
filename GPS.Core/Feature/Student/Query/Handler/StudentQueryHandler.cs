using AutoMapper;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjectStore.Core.Feature.Students.Query.Model;
using GraduationProjectStore.Core.Feature.Students.Query.Request;
using GraduationProjectStore.Core.ResultHandlers;
using GraduationProjectStore.Service.UnitOfWorks;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Students.Query.Handler
{
    public class StudentQueryHandler :
        ResultHandler,
        IRequestHandler<GetAllStudentQuery, Result<ICollection<StudentModel>>> ,
        IRequestHandler<GetStudentByIdQuery, Result<StudentModel>> 
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _service;
        public StudentQueryHandler(IUnitOfWork service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Result<ICollection<StudentModel>>> Handle
            (GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            var students = await _service.StudentService.GetAll();
            if (students == null)
                return BadRequest<ICollection<StudentModel>>(_message:"Faculty Not Has Any Students");

            var studentsMapped = _mapper.Map<ICollection<StudentModel>>(students);
            return OK<ICollection<StudentModel>>(_data:studentsMapped);  
        }

        public async Task<Result<StudentModel>> Handle
            (GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            if (request.Id <= 0)
                return BadRequest<StudentModel>(_message: "Student Not Found");

            var student = await _service.StudentService.GetOne(request.Id);
            if (student == null)
                return BadRequest<StudentModel>(_message: "Student Not Found");

            var studentMapped = _mapper.Map<StudentModel>(student);
            return OK<StudentModel>(_data: studentMapped);
        }
    }
}
