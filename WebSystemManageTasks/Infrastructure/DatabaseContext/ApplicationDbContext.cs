using Microsoft.EntityFrameworkCore;
using WebSystemManageTasks.Entities;
using WebSystemManageTasks.Infrastructure.Configurations;

namespace WebSystemManageTasks.Infrastructure.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> ProjectsTasks { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<StatusTask> StatusTasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserTask> UsersTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectTaskConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new StatusTaskConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserTaskConfiguration());
        }
    }
}
