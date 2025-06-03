using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraduationProjecrStore.Infrastructure.Persistence.Configurations.Security
{
    public class IdentityUserCliamsConfigurations : IEntityTypeConfiguration<IdentityUserClaim<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserClaim<Guid>> builder)
        {
            builder.ToTable("UserClaim").HasKey(x => new {x.Id , x.UserId });
        }
    }
}
