using Business_Logic.FakeRepositories;
using Business_Logic.Interfaces;
using Business_Logic.Models;
using Business_Logic.Models.MusicUnits;using Business_Logic.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;

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

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<MusicUnitService>();
builder.Services.AddScoped<ReviewService>();
builder.Services.AddScoped<UserAuthenticationService>();
builder.Services.AddScoped<ICurrentUserProvider, CurrentUserProvider>();

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
