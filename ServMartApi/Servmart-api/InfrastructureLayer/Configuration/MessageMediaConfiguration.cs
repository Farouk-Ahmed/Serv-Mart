using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Configuration
{
    public class MessageMediaConfiguration : IEntityTypeConfiguration<MessageMedia>
    {
        public void Configure(EntityTypeBuilder<MessageMedia> builder)
        {
            builder.ToTable("MessageMedia", "Chat");
            builder.HasOne(m => m.Message).WithMany(M => M.MessageMedias).HasForeignKey(m => m.MessageID);
        }
    }
}
