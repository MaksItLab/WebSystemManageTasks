using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSystemManageTasks.Entities;

namespace WebSystemManageTasks.Infrastructure.Configurations
{
    public class StatusTaskConfiguration : IEntityTypeConfiguration<StatusTask>
    {
        public void Configure(EntityTypeBuilder<StatusTask> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(64);

            builder.HasMany(s => s.Tasks)
                .WithOne(t => t.Status)
                .HasForeignKey(t => t.StatusId);
        }
    }
}
