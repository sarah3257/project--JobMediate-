using Software_Engineer;
using Software_Engineer.Core.Repositories;
using Software_Engineer.Core.Services;
using Software_Engineer.Data.Repositories;
using Software_Engineer.Core.Entities;
using Software_Engineer.Service;
using Software_Engineer.Data;
using System.Text.Json.Serialization;
using Software_Engineer.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<DataContext>();
builder.Services.AddDbContext<DataContext>();

builder.Services.AddScoped<IAchievementsRepository, AchievementsRepository>();
builder.Services.AddScoped<IProjectsRepository, ProjectsRepository>();
builder.Services.AddScoped<IOfficeRepository, OfficeRepository>();

builder.Services.AddScoped<IAchievementsService, AchievementsService>();
builder.Services.AddScoped<IOfficeService, OfficeService>();
builder.Services.AddScoped<IProjectsService, ProjectsService>();
builder.Services.AddAutoMapper(typeof(MappingProfile));




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
