using Domain_Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Configuration
{
	public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
	{
		public void Configure( EntityTypeBuilder<CartItem> builder )
		{
			builder.HasKey( x => x.Id );
			builder.Property( x => x.Id ).ValueGeneratedOnAdd();
			builder.HasOne( x => x.Cart ).WithMany( x => x.Items ).HasForeignKey( x => x.CartID ).OnDelete(DeleteBehavior.NoAction);

		}
	}
}
