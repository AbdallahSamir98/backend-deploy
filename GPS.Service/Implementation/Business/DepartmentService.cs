using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjecrStore.Infrastructure.Persistence.Context;
using GraduationProjecrStore.Infrastructure.Repository;
using GraduationProjectStore.Service.Abstraction.Business;

namespace GraduationProjectStore.Service.Implementation.Security
{
    public class DepartmentService : MainRepository<Department>,IDepartmentService
    {
        private readonly AppDbContext _app;

        public DepartmentService(AppDbContext app) : base(app)
        {
            this._app = app;
        }
    }
}
