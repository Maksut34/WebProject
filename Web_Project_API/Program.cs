using Microsoft.AspNetCore.Identity;
<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using Web_BLL.Abstract;
using Web_BLL.Concreate;
using Web_DAL.Abstract;
using Web_DAL.Concreate;
using Web_DTO.Abstract;
using Web_DTO.Concreate;
using Web_DTO.Data;
using Web_Entity.Models;


var builder = WebApplication.CreateBuilder(args)
    ;
builder.Services.AddScoped<IPlayerWorldMapTransformService, PlayerWorldMapTransformManager>();
builder.Services.AddScoped<IPlayerWorldMapTransform_DAL, PlayerWorldMapTransform_DAL>();
builder.Services.AddScoped<IPlayerValues_Service, PlayerValuesManager>();
builder.Services.AddScoped<IPlayerValues_DAL, PlayerValues_DAL>();
builder.Services.AddScoped<IUsersService, UsersManager>();
builder.Services.AddScoped<IUsers_DAL, Users_DAL>();
builder.Services.AddScoped<IAddStoryService, AddStoryManeger>();
builder.Services.AddScoped<IAddStory_DAL, AddStory_DAL>();
builder.Services.AddScoped<IImageService, ImageManager>();
builder.Services.AddScoped<IImage_DAL, Image_DAL>();
builder.Services.AddScoped<IUsers_InformationService, Users_InformationManager>();
builder.Services.AddScoped<IUsers_Information_DAL, Users_Information_DAL>();
builder.Services.AddScoped<IContect_Service, ContactManager>();
builder.Services.AddScoped<IContact_DAL, Contact_DAL>();



builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddIdentity<Users, Role>().AddEntityFrameworkStores<DataContext>()
                .AddDefaultTokenProviders();

=======
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using Web_Project_API.Identity;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContextAPI>();
builder.Services.AddIdentity<IdentityUsers, IdentityUsersRole>().AddEntityFrameworkStores<DataContextAPI>()
                .AddDefaultTokenProviders();

// Add services to the container.

>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
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

app.UseHttpsRedirection();
<<<<<<< HEAD
app.UseRouting();

app.UseAuthentication();
=======

>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
app.UseAuthorization();

app.MapControllers();

app.Run();
