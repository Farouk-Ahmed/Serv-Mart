using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfrastructureLayer.Configuration
{
	public class CityConfiguration : IEntityTypeConfiguration<City>
	{
		public void Configure( EntityTypeBuilder<City> builder )
		{
			builder.ToTable( "City", "Address" );
			builder.HasKey( x => x.ID );
			builder.Property( x => x.ID ).ValueGeneratedOnAdd();
			builder.Property( x => x.NameAr ).HasMaxLength( 100 );
			builder.Property( x => x.NameEn ).HasMaxLength( 100 );
		}
	}
}
