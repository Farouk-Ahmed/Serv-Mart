using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfrastructureLayer.Configuration
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {



        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Message", "Chat");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).ValueGeneratedOnAdd();
            builder.Property(i => i.Content).IsRequired().HasMaxLength(500);
            builder.Property(i => i.Date).IsRequired();
            builder.HasOne(i => i.Chat).WithMany(i => i.Messages).HasForeignKey(i => i.ChatId).IsRequired();

        }
    }
}
