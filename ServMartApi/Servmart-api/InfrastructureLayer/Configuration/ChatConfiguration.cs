using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfrastructureLayer.Configuration
{
    public  class ChatConfiguration: IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.ToTable("Chat", "Chat");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).ValueGeneratedOnAdd();
            builder.HasOne(c => c.User).WithMany(u => u.Chats).HasForeignKey(c => c.FirstUserId);
            builder.HasOne(c => c.User).WithMany(u => u.Chats).HasForeignKey(c => c.SecondUserId);


        }
    }
}
