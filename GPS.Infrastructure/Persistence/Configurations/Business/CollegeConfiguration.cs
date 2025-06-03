using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraduationProjecrStore.Infrastructure.Persistence.Configurations.Business
{
    public class CollegeConfiguration : IEntityTypeConfiguration<College>
    {
        public void Configure(EntityTypeBuilder<College> builder)
        {
            builder.ToTable("College").HasKey(x => x.Id);
        }
    }
}
