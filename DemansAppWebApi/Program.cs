using DemansAppWebApi.Services.Interfaces;
using DemansAppWebApi.Services;
using DemansAppWebApi.Repositories.Interfaces;
using DemansAppWebApi.Repositories;
using DemansAppWebApi.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DemansAppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStrings")));


builder.Services.AddScoped<IUsersService, UsersServices>();
builder.Services.AddScoped<IUserRepository, UsersRepository>();

builder.Services.AddScoped<IAudioBooksService, AudioBooksService>();
builder.Services.AddScoped<IAudioBooksRepository, AudioBooksRepository>();

builder.Services.AddScoped<ICommandsService, CommandsService>();
builder.Services.AddScoped<ICommandsRepository, CommandsRepository>();

builder.Services.AddScoped<ICompanionsService, CompanionsService>();
builder.Services.AddScoped<ICompanionsRepository, CompanionsRepository>();

builder.Services.AddScoped<ILocationInformationService, LocationInformationService>();
builder.Services.AddScoped<ILocationInformationRepository, LocationInformationRepository>();

builder.Services.AddScoped<IMedicinesService, MedicinesService>();
builder.Services.AddScoped<IMedicinesRepository, MedicinesRepository>();

builder.Services.AddScoped<IPictureService, PictureService>();
builder.Services.AddScoped<IPictureRepository, PicturesRepository>();

builder.Services.AddScoped<IMotivationSentencesService, MotivationSentencesService>();
builder.Services.AddScoped<IMotivationSentencesRepository, MotivationSentencesRepository>();

builder.Services.AddScoped<IUsersService, UsersServices>();
builder.Services.AddScoped<IUserRepository, UsersRepository>();


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
