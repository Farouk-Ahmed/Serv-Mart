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
    public class OrderItemConfigurations : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(oi => oi.ID);
            builder.Property(oi => oi.ID).ValueGeneratedOnAdd();
            builder.HasOne(oi => oi.Order).WithMany(o => o.Items).HasForeignKey(oi => oi.OrderID);
            builder.HasOne(oi => oi.Product).WithMany(p => p.OrderItems).HasForeignKey(oi => oi.ProductID).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
