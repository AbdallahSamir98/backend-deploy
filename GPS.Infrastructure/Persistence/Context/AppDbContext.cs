using GraduationProjecrStore.Infrastructure.Domain.Entities.Business;
using GraduationProjecrStore.Infrastructure.Domain.Entities.Security;
using GraduationProjecrStore.Infrastructure.Persistence.DataSeed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace GraduationProjecrStore.Infrastructure.Persistence.Context
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole,Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Contact> Contacts { set; get; }
        public DbSet<Project> Projects { set; get; }
        public DbSet<Student> Students { set; get; }
        public DbSet<Department> Departments { set; get; }  
        public DbSet<Supervisor> Supervisors { set; get; }
        public DbSet<College> Colleges { set; get; }
        public DbSet<ApplicationUser> ApplicationUsers { set; get; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);


            /////////// Data Seeder ///////////
            builder.Entity<ApplicationUser>().HasData(Seeder.UserSeed());

            var seeder = Seeder.TableSeeder();
            builder.Entity<Department>().HasData(seeder.Item3);
            builder.Entity<Supervisor>().HasData(seeder.Item2);
            builder.Entity<College>().HasData(seeder.Item5);
            builder.Entity<Project>().HasData(seeder.Item4);
            builder.Entity<Student>().HasData(seeder.Item1);
        }
    }
}
