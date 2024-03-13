
using HellocareAssessment.Api.Extensions;
using HellocareAssessment.Core.Abstractions.Services.Posts;
using HellocareAssessment.Core.Data.Contexts;
using HellocareAssessment.Core.Services;
using HellocareAssessment.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace HellocareAssessment.Api
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

            builder.Services.AddMediatr();


            builder.Services.AddDbContext<MainDbContext>(options =>
            {
                options.UseNpgsql(builder.Configuration["Database:ConnectionString"],
                        npgsqlOptionsAction: npgsqlOptions =>
                        {
                            npgsqlOptions.MigrationsHistoryTable("__MyMigrationsHistory");
                            npgsqlOptions.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(30),
                                errorCodesToAdd: null);
                            npgsqlOptions.MigrationsAssembly("HellocareAssessment.Core");
                        })
                    .UseSnakeCaseNamingConvention()
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            });

            builder.Services.AddScoped<IFeedService, FeedService>();

            builder.Services.AddMappingWithProfiles();


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

            app.Seed();

            app.Run();
        }
    }
}
