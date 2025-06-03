using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraduationProjecrStore.Infrastructure.Persistence.Configurations.Business
{
    public class ProjectConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(x => x.Id);

            // one to many with department
            builder.HasOne(x => x.Department)
              .WithMany(x => x.Projects)
              .HasForeignKey(x => x.DepartmentId)
              .OnDelete(DeleteBehavior.Restrict)
              .IsRequired(true);

            builder.HasOne(x => x.College)
               .WithMany(x => x.Projects)
               .HasForeignKey(x => x.CollegeId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired(true);
        }
    }
}
