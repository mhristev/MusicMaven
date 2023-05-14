using Business_Logic.FakeRepositories;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.MusicUnits;using Business_Logic.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;
using Business_Logic.Interfaces.IServices;using Microsoft.AspNetCore.Localization;using Data_Access_Layer.Repositories;using System.Globalization;var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IAlbumRepository, AlbumRepository>();
builder.Services.AddSingleton<ISongRepository, SongRepository>();
builder.Services.AddSingleton<IMusicUnitRepository, MusicUnitRepository>();
builder.Services.AddSingleton<IReviewRepository, ReviewRepository>();
builder.Services.AddSingleton<IArtistRepository, ArtistRepository>();
builder.Services.AddSingleton<IRepository<Album>, AlbumRepository>();
builder.Services.AddSingleton<IRepository<Artist>, ArtistRepository>();
builder.Services.AddSingleton<IRepository<Song>, SongRepository>();

builder.Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<ICurrentUserProvider, CurrentUserProvider>();

builder.Services.AddTransient<IUserService, UserService>();

builder.Services.AddTransient<IMusicUnitService, MusicUnitService>();
builder.Services.AddTransient<IAlbumService, AlbumService>();
builder.Services.AddTransient<IArtistService, ArtistService>();
builder.Services.AddTransient<ISongService, SongService>();
builder.Services.AddTransient<IReviewService, ReviewService>();
builder.Services.AddTransient<IUserAuthenticationService, UserAuthenticationService>();
builder.Services.AddTransient<ICurrentUserProvider, CurrentUserProvider>();

var mvcBuilder = builder.Services.AddRazorPages();

if (builder.Environment.IsDevelopment())
{
    mvcBuilder.AddRazorRuntimeCompilation();
}

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(2);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;

});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = new PathString("/SignIn");
        options.LogoutPath = new PathString("/Logout");
        options.AccessDeniedPath = new PathString("/LikeReview");
        options.AccessDeniedPath = new PathString("/CreateReview");
    });

builder.Services.Configure<RequestLocalizationOptions>(options =>{    options.DefaultRequestCulture = new RequestCulture(CultureInfo.CurrentCulture);});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseSession();

app.MapRazorPages();

app.Run();
