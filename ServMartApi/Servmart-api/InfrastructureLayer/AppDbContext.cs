using InfrastructureLayer.Configuration;
using InfrastructureLayer.Helpers;
using Domain_Layer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Application_Layer.Configuration;

namespace InfrastructureLayer
{
	public class AppDbContext : IdentityDbContext<User>
	{
		public AppDbContext( DbContextOptions options ) : base( options )
		{

		}

		protected override void OnModelCreating( ModelBuilder builder )
		{
			builder.ApplyConfiguration<Chat>( new ChatConfiguration() );
			builder.ApplyConfiguration<User>( new UserConfiguration() );
			builder.ApplyConfiguration<Message>( new MessageConfiguration() );
			builder.ApplyConfiguration<MessageMedia>( new MessageMediaConfiguration() );
			builder.ApplyConfiguration<ProductCategory>( new ProductCategoryConfigurstion() );
			builder.ApplyConfiguration<Product>( new ProductConfigurstion() );
			builder.ApplyConfiguration<ProductMedia>( new ProductMediaConfiguration() );
			builder.ApplyConfiguration<ProductRate>( new ProductRateconfigurstion() );
			builder.ApplyConfiguration<Request>( new RequestConfiguration() );
			builder.ApplyConfiguration<RequestMedia>( new RequestMediaConfiguration() );
			builder.ApplyConfiguration<RequestOffer>( new RequestOfferConfiguratoin() );
			builder.ApplyConfiguration<ServiceCategory>( new ServiceCategoryConfiguration() );
			builder.ApplyConfiguration<Service>( new ServiceConfiguration() );
			builder.ApplyConfiguration<ServiceMedia>( new ServiceMediaConfiguration() );
			builder.ApplyConfiguration<ServiceRate>( new ServiceRateConfiguration() );
			builder.ApplyConfiguration<Governorate>( new GovernorateConfiguration() );
			builder.ApplyConfiguration<City>( new CityConfiguration() );
			builder.ApplyConfiguration<Cart>( new CartConfigurations() );
			builder.ApplyConfiguration<CartItem>( new CartItemConfiguration() );
			builder.ApplyConfiguration<Order>( new OrderConfigurations() );
			builder.ApplyConfiguration<OrderItem>( new OrderItemConfigurations() );
			builder.ApplyConfiguration<Notifications>( new NotificationsConfiguration() );
			builder.SeedRoles();
			builder.SeedGovernorate();
			builder.SeedCity();
			builder.SeedRequestAndServiceCategories();

			base.OnModelCreating( builder );

		}

		public DbSet<Chat> Chat { get; set; }
		public DbSet<Message> Message { get; set; }
		public DbSet<MessageMedia> MessageMedia { get; set; }
		public DbSet<Product> Product { get; set; }
		public DbSet<ProductCategory> ProductCategorie { get; set; }
		public DbSet<ProductMedia> productMedia { get; set; }
		public DbSet<ProductRate> ProductRate { get; set; }
		public DbSet<Request> Request { get; set; }
		public DbSet<RequestMedia> RequestMedia { get; set; }
		public DbSet<RequestOffer> RequestOffer { get; set; }
		public DbSet<Service> Service { get; set; }
		public DbSet<ServiceMedia> ServiceMedia { get; set; }
		public DbSet<ServiceCategory> ServiceCategorie { get; set; }
		public DbSet<ServiceRate> ServiceRate { get; set; }
		public DbSet<Governorate> Governorates { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<Cart> Cart { get; set; }
		public DbSet<CartItem> CartItem { get; set; }
		public DbSet<Order> Order { get; set; }
		public DbSet<OrderItem> OrderItem { get; set; }
		public DbSet<Notifications> Notifications { get; set; }

	}
}
