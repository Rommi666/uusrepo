using CustomerApi.Models;

using Microsoft.EntityFrameworkCore;

namespace CustomerApi

{

    public class Program

    {

        public static void Main(string[] args)

        {

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<CustomerContext>(options =>

            options.UseSqlServer(builder.Configuration.GetConnectionString("CustomerContext")));

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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

    }

}