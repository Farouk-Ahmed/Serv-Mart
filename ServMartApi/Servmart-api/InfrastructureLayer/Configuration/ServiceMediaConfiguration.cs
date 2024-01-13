using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application_Layer.Configuration
{
	public class ServiceMediaConfiguration : IEntityTypeConfiguration<ServiceMedia>
	{
		public void Configure( EntityTypeBuilder<ServiceMedia> builder )
		{
			builder.ToTable( "ServiceMedia", "Service" );
			builder.HasKey( i => i.ID );
			builder.Property( i => i.ID ).ValueGeneratedOnAdd();
			builder.Property( m => m.MediaUrl ).IsRequired();

			builder.HasOne( i => i.Service ).WithMany( i => i.ServiceMedia ).HasForeignKey( i => i.ServiceID ).OnDelete( DeleteBehavior.Cascade ).IsRequired();
		}
	}
}
