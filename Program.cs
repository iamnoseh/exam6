using Domain;
using Infrastructure.ApplicationService;
using Infrastructure.DataContext;
using Infrastructure.JobService;
using Infrastructure.UserService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<DapperContext>();
builder.Services.AddScoped<JobService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<ApplicationService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json", "WebApp v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();