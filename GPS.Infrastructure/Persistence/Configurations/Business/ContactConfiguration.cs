using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraduationProjecrStore.Infrastructure.Persistence.Configurations.Business
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact").HasKey(x=>x.Id);

            builder.HasOne(x=>x.User)
                .WithMany(x=>x.Contacts)
                .HasForeignKey(x=>x.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);
        }
    }
}
