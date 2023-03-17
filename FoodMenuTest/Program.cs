using FoodMenuTest.Data;
using FoodMenuTest.Data.Repositories;
using FoodMenuTest.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, UserRepository>();



#region Add db context   

builder.Services.AddDbContext<foodMenuContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("foodMenuContext"));
});
#endregion


#region AddCors

builder.Services.AddCors();
#endregion



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

app.UseHttpsRedirection();

#region Use Cors

app.UseCors(p => p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
#endregion


app.UseAuthorization();

app.MapControllers();

app.Run();
