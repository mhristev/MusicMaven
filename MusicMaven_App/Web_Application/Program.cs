using Business_Logic.FakeRepositories;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.MusicUnits;using Business_Logic.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;
using Business_Logic.Interfaces.IServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IUserRepository, FakeUserRepository>();
builder.Services.AddSingleton<IAlbumRepository, FakeAlbumRepository>();
builder.Services.AddSingleton<ISongRepository, FakeSongRepository>();
builder.Services.AddSingleton<IMusicUnitRepository, FakeMusicUnitRepository>();
builder.Services.AddSingleton<IReviewRepository, FakeReviewRepository>();
builder.Services.AddSingleton<IArtistRepository, FakeArtistRepository>();
builder.Services.AddSingleton<IRepository<Album>, FakeAlbumRepository>();
builder.Services.AddSingleton<IRepository<Artist>, FakeArtistRepository>();
builder.Services.AddSingleton<IRepository<Song>, FakeSongRepository>();

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
