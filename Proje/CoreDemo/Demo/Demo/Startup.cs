using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Demo
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<Context>();
			services.AddControllersWithViews();

			services.AddAuthentication(
				CookieAuthenticationDefaults.AuthenticationScheme)
				.AddCookie(x => {
					x.LoginPath = "/Admin/Index"; });

			
			services.AddSession();

			services.AddDbContext<Context>();
			services.AddControllersWithViews();
			services.AddMvc(config =>
			{
				var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
				config.Filters.Add(new AuthorizeFilter(policy));
			}
			);
			services.AddAuthorization();
			services.AddSession();
			services.AddAuthorization(options =>
			{
				options.AddPolicy("RequireLoggedIn", policy =>
				{
					policy.RequireAuthenticatedUser();
				});
			});
		}
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseRouting();
			app.UseSession();
			app.UseAuthentication();
		
			app.UseAuthorization();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "areas",
					pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
			);
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
