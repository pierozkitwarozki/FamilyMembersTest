using System.Security.Authentication;
using FamilyMembers.API.Configuration;
using FamilyMembers.API.Models;
using FamilyMembers.API.Repos;
using FamilyMembers.API.Services;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

builder.Services.InstallServicesAndControllers(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
