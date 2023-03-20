using Book_Store.Models;
using Book_Store.Repository.Author_Repo;
using Book_Store.Repository.Books_Repo;
using Book_Store.Repository.CustomerCart_Repo;
using Book_Store.Repository.Orders_Repo;
using Book_Store.Repository.Publisher_Repo;
using Book_Store.Repository.Types_Repo;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Book_Store
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<BookStoreContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Cs"));
            });

            // Add identity service to work on users & admins, and declare which store you used
            builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<BookStoreContext>();


            // [Authorize] used "JWT Token" in check Authentication 
            builder.Services.AddAuthentication(options =>
            {
                //check signature==>  Authorize or Unauthorize 
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;

                // signature Invalid==> redirect to Login form
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

                // for any defualt scheme==> use default jwt bearer 
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

                // check==> token from the same domain
            }).AddJwtBearer(options =>
            {
                // check==> expire time
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    // check==> provider 
                    ValidateIssuer = true,
                    ValidIssuer = builder.Configuration["JWT:ValidIssuer"],

                    // check==> consumer
                    ValidateAudience = true,
                    ValidAudience = builder.Configuration["JWT:ValidAudience"],

                    // check==> key
                    IssuerSigningKey =
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
                };
            });

                //Auto Mapper Registeration
                builder.Services.AddAutoMapper(typeof(Program));

            // add scoped
            builder.Services.AddScoped<IBookRepository, BookRepository>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
            builder.Services.AddScoped<ITypesRepository, TypesRepository>();
            builder.Services.AddScoped<IPublisherRepository, PublisherRepository>();
            builder.Services.AddScoped<ICustomerCartRepository, CustomerCartRepository>();

            //Enable CORS
            builder.Services.AddCors();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

            app.UseAuthentication(); // by default check cookie, but i wanna check jwt "Token"

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}