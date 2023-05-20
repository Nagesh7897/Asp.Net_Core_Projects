using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using StudentOnboarding.Models;
using System;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//DI for DbContext
builder.Services.AddDbContext<DatabaseContext>(Options =>
Options.UseSqlServer(builder.Configuration.GetConnectionString("StudentConnection")));


//To make one to many relationship
builder.Services.AddControllersWithViews()
 .AddJsonOptions(options =>
 options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
app.MapControllerRoute(
  name: "default",
 pattern: "{controller=Students}/{action=Index}/{id?}");

app.Run();
