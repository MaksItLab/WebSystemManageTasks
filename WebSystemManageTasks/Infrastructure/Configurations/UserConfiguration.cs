using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSystemManageTasks.Entities;

namespace WebSystemManageTasks.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                .HasMaxLength(64);

            builder.Property(u => u.Surname)
                .HasMaxLength(64);

            builder.Property(u => u.Email)
                .HasMaxLength(64);

            builder.Property(u => u.Login)
                .IsRequired();

            builder.Property(u => u.PasswordHash)
                .IsRequired();

            builder.HasOne(u => u.Project)
                .WithMany(p => p.Users)
                .HasForeignKey(u => u.ProjectId);

            builder.HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            builder.HasMany(u => u.UserTasks)
                .WithOne(ut => ut.User)
                .HasForeignKey(ut => ut.UserId);
        }
    }
}
