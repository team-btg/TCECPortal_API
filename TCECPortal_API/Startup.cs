using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting; 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting; 
using System; 
using TCECPortal_API.Data;
using TCECPortal_API.Data.DataAccess.Interface;
using TCECPortal_API.Data.DataAccess.Repository;
using TCECPortal_API.Data.Implementation;
using TCECPortal_API.Data.Interface; 
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace TCECPortal_API
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
            services.AddControllers();
            services.AddDbContext<DataContext>(opt => opt.UseSqlServer
                (Configuration.GetConnectionString("APIConnection")));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            #region "Repository"
            services.AddTransient<IUserRepository, UserRepository>();
            #endregion

            #region "Services"
            services.AddTransient<IUser, UserService>();
            #endregion

            services.AddControllers().AddOData(opt => opt.Count().Filter().Expand().Select().OrderBy());

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = "http://161.49.173.194/",
                    ValidIssuer = "http://161.49.173.194/",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("7S79jvOkEdwoRqHx"))
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
