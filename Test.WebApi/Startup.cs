using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Business.Abstract;
using Test.Business.Concrete;
using Test.DataAccess;
using Test.DataAccess.Abstract;
using Test.DataAccess.Concrete.EntityFramework;
using Test.WebApi.CustomMiddleware;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Test.WebApi 
{
	/// <summary>
	/// Generated by ElementalBuilder (12.11.2019 16:39:22)
	/// </summary>
	public class Startup 
	{
		public Startup(IConfiguration configuration) 
		{
			Configuration = configuration; 
		}

		public IConfiguration Configuration { get; } 

		public void ConfigureServices(IServiceCollection services) 
		{
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1); 

			services.AddScoped<IIsyeriService, IsyeriManager>();  
			services.AddScoped<IIsyeriDal, EfIsyeriDal>();  
			services.AddScoped<IMusteriService, MusteriManager>();  
			services.AddScoped<IMusteriDal, EfMusteriDal>();  
			services.AddScoped<IEmlakService, EmlakManager>();  
			services.AddScoped<IEmlakDal, EfEmlakDal>();  
			services.AddScoped<IUserService, UserManager>();  
			services.AddScoped<IUserDal, EfUserDal>();  

			_GlobalFields.ConnectionStr = Configuration.GetConnectionString("TestDbContext");  

			#region JWT  
			var key = Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Token").Value);  
			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>  
			{
				options.TokenValidationParameters = new TokenValidationParameters()  
				{
					ValidateIssuerSigningKey = true,  
					IssuerSigningKey = new SymmetricSecurityKey(key),  
					ValidateIssuer = false,  
					ValidateAudience = false  
				};
			});
			#endregion 
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env) 
		{
			if (env.IsDevelopment()) 
			{
				 app.UseDeveloperExceptionPage(); 
			}
			app.UseAuthentication(); 
			app.UseMvc(); 
		}
	}
}
	// C:\Users\manas\source\repos\Test\Test.WebApi\ 
