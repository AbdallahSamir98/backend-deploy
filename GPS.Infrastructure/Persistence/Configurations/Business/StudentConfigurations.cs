using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraduationProjecrStore.Infrastructure.Persistence.Configurations.Business
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student").HasKey(x => x.Id);

            // one to many with department
            builder.HasOne(x => x.Department)
                .WithMany(x=>x.Students)
                .HasForeignKey(x=>x.DepartmentId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            // one to many with project
            builder.HasOne(x=>x.Project)
                .WithMany(x=>x.Students)
               .HasForeignKey(x => x.ProjectId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            // one to many with supervisor 

            builder.HasOne(x => x.Supervisor)
                .WithMany(x => x.Students)
                .HasForeignKey(x => x.SupervisorId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}
