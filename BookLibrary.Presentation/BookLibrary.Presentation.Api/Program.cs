using AutoMapper;
using BookLibrary.Core.Application;
using BookLibrary.Core.Application.Services.Commands.Book.Insert;
using BookLibrary.Infrastructure.Persistence;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices();
builder.Services.AddMediatR(typeof(Program) );

var config = new MapperConfiguration(conf =>
{
    conf.AddProfile<BookInsertCommandMapper>();
});
builder.Services.AddScoped(s => config.CreateMapper());

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
