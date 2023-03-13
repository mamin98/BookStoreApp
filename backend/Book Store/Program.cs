using Book_Store.Models;
using Book_Store.Repository.Author_Repo;
using Book_Store.Repository.Books_Repo;
using Book_Store.Repository.Orders_Repo;
using Book_Store.Repository.Publisher_Repo;
using Book_Store.Repository.Types_Repo;
using Microsoft.EntityFrameworkCore;

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

            //Auto Mapper Registeration
            builder.Services.AddAutoMapper(typeof(Program));

            // add scoped
            builder.Services.AddScoped<IBookRepository, BookRepository>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
            builder.Services.AddScoped<ITypesRepository, TypesRepository>();
            builder.Services.AddScoped<IPublisherRepository, PublisherRepository>();

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

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}