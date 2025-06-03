using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjecrStore.Infrastructure.Persistence.Context;
using GraduationProjecrStore.Infrastructure.Repository;
using GraduationProjectStore.Service.Abstraction.Business;

namespace GraduationProjectStore.Service.Implementation.Security
{
    public class SupervisorService : MainRepository<Supervisor>, ISupervisorService
    {
        private readonly AppDbContext _app; 
        public SupervisorService(AppDbContext app) : base(app)
        {
            this._app = app;
        }
    }
}
