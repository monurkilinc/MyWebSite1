using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication()
        .AddCookie(options =>
        {
            options.LoginPath = "/Login/Index/";
        });
//No:88 Login i�lemi i�in eklendi
builder.Services.AddAuthentication();

//No:87 Kullan�c� giri�i i�in eklendi
builder.Services.AddSession();




//No:87 Authorize i�lemi i�in yaz�lan metotlar
builder.Services.AddMvc(config =>
{

    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser().Build();

    config.Filters.Add(new AuthorizeFilter(policy));

});
var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//No:82 Yanl�� giri� yap�lan sayfalar� otomatik olarak Error1 hata sayfas�na y�nlendirir
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//No:87 Kullan�c� giri�i i�in eklendi
app.UseSession();

app.MapControllerRoute( 
    name: "default",
    pattern: "{controller=Blog}/{action=Index}/{id?}");


//No:113 Area ifadesini kullanabilmek i�in a�a��daki ifade eklendi
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
});


app.Run();
