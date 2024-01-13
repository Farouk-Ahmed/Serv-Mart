using Application_Layer.Repos;
using Application_Layer.Services;
using ApplicationLayer.IRepos;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using InfrastructureLayer;
using InfrastructureLayer.Interfaces;
using InfrastructureLayer.Repos;
using InfrastructureLayer.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Sermart_Api.Helpers;
using Sermart_Api.Mapper;
using System.Text;
using System.Text.Json.Serialization;
using Application_Layer.Interfaces;
using Microsoft.OpenApi.Models;
using Application_Layer.Helpers;

namespace Sermart_Api
{
	public class Program
	{
		public static void Main( string[] args )
		{
			var builder = WebApplication.CreateBuilder( args );
			builder.Services.AddControllers().AddJsonOptions( x =>
				x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles );
			// Add services to the container.
			builder.Services.Configure<JWT>( builder.Configuration.GetSection( "JWT" ) );
			builder.Services.Configure<CloudinraySettings>( builder.Configuration.GetSection( "CloudinarySettings" ) );
			builder.Services.AddScoped( typeof( IBaseRepo<> ), typeof( BaseRepos<> ) );
			builder.Services.AddScoped<IUserRepo, UserRepo>();
			builder.Services.AddScoped<IAuthService, AuthService>();
			builder.Services.AddScoped<IPhotoService, PhotoService>();
			builder.Services.AddScoped<IVideoService, VideoService>();
			builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
			builder.Services.AddScoped<IProduct, Products>();
			builder.Services.AddScoped<IProductCatgory, ProductCatgoryRepo>();
			builder.Services.AddScoped<IAddressRepo, AddressRepo>();
			builder.Services.AddScoped<IRequestServiceCategory, RequestServiceCategory>();
			builder.Services.AddScoped<IcartItemRepo, CartItemRepo>();

			builder.Services.AddAutoMapper( p => p.AddProfile( new productProfile() ) );
			builder.Services.AddAutoMapper( p => p.AddProfile( new CatgoryProfile() ) );
			builder.Services.AddScoped<IRequestRepo, RequsestRepo>();
			builder.Services.AddScoped<IAuthRepo, AuthRepo>();
			builder.Services.AddScoped<IRequestOfferRepo, RequestOfferRepo>();
			builder.Services.AddScoped<IServiceRepo, ServiceRepo>();
			builder.Services.AddScoped<IOrderRepo, OrderRepo>();
			builder.Services.AddScoped<INotificationRepo, NotificationRepo>();
			builder.Services.AddScoped<VendorSoldProductsRepo>();
			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen( c =>
			{
				c.AddSecurityDefinition( "Bearer", new OpenApiSecurityScheme
				{
					Description = "JWT Authorization header using bearer scheme",
					Name = "Authorization",
					In = ParameterLocation.Header,
					Type = SecuritySchemeType.ApiKey,
					Scheme = "Bearer"
				} );
				c.AddSecurityRequirement( new OpenApiSecurityRequirement
				{
					{
						new OpenApiSecurityScheme
						{
							Reference = new OpenApiReference
							{
								Type = ReferenceType.SecurityScheme,
								Id = "Bearer"
							}
						},
						new string[]{ }
					}
				} );
			} );
			builder.Services.AddDbContext<AppDbContext>( options =>
			{
				options.UseLazyLoadingProxies().UseSqlServer( builder.Configuration.GetConnectionString( "DefaultConnection" ),
					m => m.MigrationsAssembly( typeof( AppDbContext ).Assembly.FullName ) );
			} );
			builder.Services.AddIdentity<User, IdentityRole>( options =>
			{
				options.Password.RequireDigit = true;
				options.Password.RequireLowercase = true;
				options.Password.RequireUppercase = true;
				options.Password.RequiredLength = 8;
			} )
			.AddEntityFrameworkStores<AppDbContext>()
			.AddDefaultTokenProviders();
			builder.Services.AddCors();

			builder.Services.AddAuthentication( options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

			} ).AddJwtBearer( o =>
			{
				o.RequireHttpsMetadata = false;
				o.SaveToken = false;
				o.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuerSigningKey = true,
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidIssuer = builder.Configuration[ "JWT:Issuer" ],
					ValidAudience = builder.Configuration[ "JWT:Audience" ],
					IssuerSigningKey = new SymmetricSecurityKey( Encoding.UTF8.GetBytes( builder.Configuration[ "JWT:Key" ] ) )
				};
			} );

			builder.Services.Configure<FormOptions>( Option =>
			{
				Option.ValueLengthLimit = int.MaxValue;
				Option.MultipartBodyLengthLimit = int.MaxValue;
				Option.MemoryBufferThreshold = int.MaxValue;

			} );

			builder.Services.AddSignalR();


			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if ( app.Environment.IsDevelopment() )
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthentication();
			app.UseAuthorization();


			app.UseCors( builder => builder
				.AllowAnyMethod()
				.AllowAnyHeader()
				.SetIsOriginAllowed( ( host ) => true ) // Allow any origin for testing; tighten this in production
				.AllowCredentials() );

			app.MapHub<NotificationHub>( "/notificationHub" );
			app.MapControllers();



			app.Run();
		}
	}
}