using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Web_BLL.Abstract;
using Web_BLL.Concreate;
using Web_DAL.Abstract;
using Web_DAL.Concreate;
using Web_DTO.Abstract;
using Web_DTO.Concreate;
using Web_DTO.Data;
using Web_Entity.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IUsersService, UsersManager>();
builder.Services.AddScoped<IUsers_DAL, Users_DAL>();
builder.Services.AddScoped<IAddStoryService, AddStoryManeger>();
builder.Services.AddScoped<IAddStory_DAL, AddStory_DAL>();
builder.Services.AddScoped<IImageService, ImageManager>();
builder.Services.AddScoped<IImage_DAL, Image_DAL>();
builder.Services.AddScoped<IUsers_InformationService, Users_InformationManager>();
builder.Services.AddScoped<IUsers_Information_DAL, Users_Information_DAL>();

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddIdentity<Users, Role>().AddEntityFrameworkStores<DataContext>()
                .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = true;

    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.AllowedForNewUsers = true;

    //options.User.AllowedUserNameCharacters = "1";
    options.SignIn.RequireConfirmedPhoneNumber = false;
    options.SignIn.RequireConfirmedEmail = false;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login/Login";
    options.LogoutPath = "/Login/Login";
    options.AccessDeniedPath = "/account/accessDenied";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
    options.SlidingExpiration = true;
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true,
        Name = "Web_Project.Security.Cookie",
        SameSite = SameSiteMode.Strict
    };
});
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
});

builder.Services.AddRazorPages();
builder.Services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest);


var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Keþfet}/{id?}");

app.Run();
