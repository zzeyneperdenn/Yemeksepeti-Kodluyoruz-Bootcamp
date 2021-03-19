using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW8.Contexts;
using HW8.Filters;
using HW8.Infrastructure;
using HW8.Models.Derived;
using HW8.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace HW8
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<HotelInfo>(Configuration.GetSection("HotelInfo"));

            services.AddDbContext<HotelApiDbContext>(options =>
            {
                options.UseInMemoryDatabase("HotelDb");
            });
            services.AddControllers(options=>
            {
                options.Filters.Add(typeof(JsonExceptionFilters));
                options.Filters.Add<AllowOnlyRequireHttps>();
            });

            services.AddAutoMapper(option => option.AddProfile<MappingProfile>());
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<IUserService, UserService>();

            string key = Configuration.GetValue<string>("JwtTokenKey");
            byte[] keyValue = Encoding.UTF8.GetBytes(key);
            services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(jwt =>
            {
                jwt.RequireHttpsMetadata = true;
                //jwt.SaveToken = true;
                jwt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(keyValue),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    //ClockSkew = 
                };
            });

            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddSwaggerDocument();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwaggerUi3();

                app.UseOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
