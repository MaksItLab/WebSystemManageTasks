using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSystemManageTasks.Entities;

namespace WebSystemManageTasks.Infrastructure.Configurations
{
    public class UserTaskConfiguration : IEntityTypeConfiguration<UserTask>
    {
        public void Configure(EntityTypeBuilder<UserTask> builder)
        {
            builder.HasKey(ut => new { ut.UserId, ut.TaskId });

            builder.HasOne(ut => ut.User)
                .WithMany(u => u.UserTasks)
                .HasForeignKey(ut => ut.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ut => ut.Task)
                .WithMany(t => t.TaskUsers)
                .HasForeignKey(ut => ut.TaskId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
