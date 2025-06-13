using CORE.repositories;
using CORE.service;
using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//I need to add her the function that turns in to json
//circle controller

//????? ?SQL
builder.Services.AddDbContext<DataContex>(options =>
options.UseSqlServer(@"Server=localhost\\SQLEXPRESS;Database=Recipe;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"));


//?????? ????? ???????
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});
//????? ?? ???????
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService> ();

builder.Services.AddScoped<IIngredientRepository, IngredientRepository>();
builder.Services.AddScoped<IIngredientService, IngredientService>();

builder.Services.AddScoped<IRecipiesRepository, RecipiesRepository>();
builder.Services.AddScoped<IRecipeService, RecipeService>();

builder.Services.AddScoped<IIngredient_RecipeRepository, Ingredient_RecipeRepository>();
builder.Services.AddScoped<IIngredient_RecipeService, Ingredient_RecipeService>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}

app.UseCors("AllowAll");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseStaticFiles();

app.Run();
