using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace MyWebSite1
{
	public class Startup
	{
		public void ConfigureService(IServiceCollection services)
		{
			services.AddMvc();

			services.AddSession();


			//No:87 AddAuthentication işlemi
			services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)

			 .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
			 {

				 options.LoginPath = "/Login/Index/";

			 });

		}
		public void Configure(IApplicationBuilder app, IHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}
			app.UseSession();
			app.UseStaticFiles();
			//No:88 Login işlemi için eklendi
			app.UseAuthentication();
			app.UseRouting();
			app.UseAuthorization();
			app.UseMvc(routes =>
			{

				routes.MapRoute(
					name: "default",
					template: "{controller=Blog}/{action=Index}/{id?}");

			});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.UseCookiePolicy();
		}
	}
}
