using AmwalPay.DAL.Context;
using AmwalPay.Services.ServiceLayer.IServices;
using AmwalPay.Services.ServiceLayer.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ITransactionService, TransactionService>();



//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("CorsPolicy",
//        builder => builder.WithOrigins(Configuration["ApplicationSettings:Client_URL"].ToString())
//        .AllowAnyMethod()
//        .AllowAnyHeader()
//        .AllowCredentials());
//});
builder.Services.AddDbContext<AmwalPayDbContext>(options =>
      options.UseSqlServer(builder.Configuration.GetConnectionString("AmwalPayConnection")));
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