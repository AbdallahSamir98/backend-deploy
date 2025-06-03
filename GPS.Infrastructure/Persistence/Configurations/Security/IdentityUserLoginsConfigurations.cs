using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraduationProjecrStore.Infrastructure.Persistence.Configurations.Security
{
    public class IdentityUserLoginsConfigurations : IEntityTypeConfiguration<IdentityUserLogin<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserLogin<Guid>> builder)
        {
            builder.ToTable("UserLogin").HasKey(x => new { x.UserId , x.ProviderKey , x.LoginProvider});
        }
    }
}
