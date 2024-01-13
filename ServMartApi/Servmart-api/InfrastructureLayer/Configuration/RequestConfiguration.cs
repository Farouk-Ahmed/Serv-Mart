using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain_Layer.Models;

namespace InfrastructureLayer.Configuration
{
	public class RequestConfiguration : IEntityTypeConfiguration<Request>
	{


		public void Configure( EntityTypeBuilder<Request> builder )
		{
			builder.ToTable( "Request", "Request" );
			builder.HasKey( i => i.ID );
			builder.Property( i => i.ID ).ValueGeneratedOnAdd();
			builder.Property( i => i.Details ).IsRequired().HasMaxLength( 500 );
			builder.Property( i => i.Title ).IsRequired().HasMaxLength( 500 );
			builder.Property( i => i.ExpectedSalary ).IsRequired();
			builder.Property( i => i.Status ).IsRequired();
			builder.Property( i => i.CreatedAt ).IsRequired();
			builder.Property( i => i.Duration ).IsRequired();
			builder.Property( i => i.RateValue ).IsRequired();
			builder.Property( i => i.RateMassage ).IsRequired().HasMaxLength( 500 );
			builder.Property( d => d.IsDirect ).IsRequired().HasColumnType( "bit" );

			//CLIENTID

			builder.HasOne( x => x.User ).WithMany( x => x.Request ).HasForeignKey( x => x.UserID ).OnDelete( DeleteBehavior.NoAction ).IsRequired();

			builder.HasOne( x => x.Governorate ).WithMany( x => x.Request ).HasForeignKey( x => x.GovernorateId ).OnDelete( DeleteBehavior.NoAction ).IsRequired();
			builder.HasOne( x => x.City ).WithMany( x => x.Request ).HasForeignKey( x => x.CityId ).OnDelete( DeleteBehavior.NoAction ).IsRequired();

		}
	}
}
