using GraduationProjecrStore.Infrastructure.Domain.Entities.Business.Common;

namespace GraduationProjecrStore.Infrastructure.Domain.Entities.Business
{
    public sealed class College : TableIdentity
    {
        public ICollection<Project> Projects { set; get; }
    }
}
