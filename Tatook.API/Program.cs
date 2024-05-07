using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tatook.Domain.Commands;
using Tatook.Domain.Entities.Users;
using Tatook.Domain.Handlers;
using Tatook.Infrastructure.Data.Context;
using Tatook.Infrastructure.Repositories.Users;
using Tatook.Shared.Handlers;

namespace Tatook.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            ConfigureServices(builder);
            ConfigureConnection(builder);
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

        static void ConfigureConnection(WebApplicationBuilder builder)
        {
            //var connString = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<TatookDbContext>();

            //builder.Services.AddDbContext<TatookDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

        }

        static void ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddScoped<IUserRepository,UserRepository>();
            builder.Services.AddScoped<IHandler<CreateUserCommand>,UserHandler>();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
        }
    }
}
