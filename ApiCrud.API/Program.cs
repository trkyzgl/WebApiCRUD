using ApiCrud.Business.Abstract;
using ApiCrud.Business.Concrete;
using ApiCrud.DataAccess.Abstract;
using ApiCrud.DataAccess.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Eklediklerim

builder.Services.AddMvc();  
builder.Services.AddControllers();
//builder.Services.AddSingleton<IHotelService, HotelManager>();
//builder.Services.AddSingleton<IHotelRepository, HotelRepository>();



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

