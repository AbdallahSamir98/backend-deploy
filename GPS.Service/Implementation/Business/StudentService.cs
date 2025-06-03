using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjecrStore.Infrastructure.Persistence.Context;
using GraduationProjecrStore.Infrastructure.Repository;
using GraduationProjectStore.Service.Abstraction.Business;

namespace GraduationProjectStore.Service.Implementation.Business
{
    public class StudentService : MainRepository<Student>, IStudentService
    {
        private readonly AppDbContext _app;
        public StudentService(AppDbContext app) : base(app)
        {
            _app = app;
        }
    }
}
