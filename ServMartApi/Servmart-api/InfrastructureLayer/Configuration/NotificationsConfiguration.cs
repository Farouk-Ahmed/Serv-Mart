using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application_Layer.Configuration
{
	public class NotificationsConfiguration : IEntityTypeConfiguration<Notifications>
	{
		public void Configure( EntityTypeBuilder<Notifications> builder )
		{
			builder.ToTable( "Notifications" );
			builder.HasKey( x => x.Id );
			builder.Property( n => n.CreatedAt ).HasDefaultValueSql( "GETDATE()" );

			builder.HasOne( n => n.User ).WithMany( u => u.Notifications ).HasForeignKey( n => n.UserId ).OnDelete( DeleteBehavior.Cascade );
		}
	}
}
