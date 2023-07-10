using ApiCrud.Business.Abstract;
using ApiCrud.Business.Concrete;
using ApiCrud.DataAccess;
using ApiCrud.DataAccess.Abstract;
using ApiCrud.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Eklediklerim

builder.Services.AddMvc();  
builder.Services.AddControllers();
builder.Services.AddDbContext<HotelDbContext>(options => {
    options.UseSqlServer("Server=DESKTOP-IL6RP3E\\SQLEXPRESS;Database=ApiCRUD;Trusted_Connection=True;");
});
builder.Services.AddScoped<IHotelService, HotelManager>();
builder.Services.AddScoped<IHotelRepository, HotelRepository>();
//

builder.Services.AddScoped<ICarService, CarManager>();
builder.Services.AddScoped<ICarRepository, CarRepository>();

//



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.UseEndpoints(endpoints => endpoints.MapControllers()); // sonradan ekledim
app.Run();

