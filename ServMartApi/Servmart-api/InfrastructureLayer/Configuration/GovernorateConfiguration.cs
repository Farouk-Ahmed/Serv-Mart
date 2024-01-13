using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfrastructureLayer.Configuration
{
	public class GovernorateConfiguration : IEntityTypeConfiguration<Governorate>
	{
		public void Configure( EntityTypeBuilder<Governorate> builder )
		{
			builder.ToTable( "Governorate", "Address" );
			builder.HasKey( x => x.ID );
			builder.Property( x => x.ID ).ValueGeneratedOnAdd();
			builder.Property( x => x.NameAr ).HasMaxLength( 100 );
			builder.Property( x => x.NameEn ).HasMaxLength( 100 );

			builder.HasMany( x => x.Cities ).WithOne( x => x.Governorate ).HasForeignKey( x => x.GovernorateId );
		}
	}
}
