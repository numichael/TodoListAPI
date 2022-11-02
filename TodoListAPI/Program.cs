using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.Text;
using TodoListAPI.Data;
using TodoListAPI.Models;
using TodoListAPI.Models.Authentication;
using TodoListAPI.Repositories.Implementation;
using TodoListAPI.Repositories.Interfaces;
using TodoListAPI.Services.Implementation;
using TodoListAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("ToDoItemConnection")));

builder.Services.AddApplicationService();
builder.Services.AddTransient<ITodoTaskRepository, TodoTaskRepository>();
builder.Services.AddTransient<ITodoTaskService, TodoTaskService>();
builder.Services.AddTransient<IRepositoryWrapper, RepositoryWrapper>();
builder.Services.AddAutoMapper(typeof(Program));

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
