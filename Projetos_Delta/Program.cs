using Microsoft.EntityFrameworkCore;

using Projetos_Delta.Data;
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<Projetos_DeltaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Projetos_DeltaContext") ?? throw new InvalidOperationException("Connection string 'Projetos_DeltaContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();

}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<Projetos_DeltaContext>();
    SeedingService.Seed(context);
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
