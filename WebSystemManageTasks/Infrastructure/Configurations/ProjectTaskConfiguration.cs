using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSystemManageTasks.Entities;

namespace WebSystemManageTasks.Infrastructure.Configurations
{
    public class ProjectTaskConfiguration : IEntityTypeConfiguration<ProjectTask>
    {
        public void Configure(EntityTypeBuilder<ProjectTask> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .IsRequired();

            builder.Property(t => t.Name)
                .HasMaxLength(50);

            builder.Property(t => t.Description)
                .HasMaxLength(900);

            builder.HasOne(t => t.Status)
                .WithMany(s => s.Tasks)
                .HasForeignKey(t => t.StatusId);

            builder.HasOne(t => t.Project)
                .WithMany(p => p.Tasks)
                .HasForeignKey(t => t.ProjectId);

            builder.HasMany(t => t.TaskUsers)
                .WithOne(ut => ut.Task)
                .HasForeignKey(ut => ut.TaskId);
        }
    }
}
