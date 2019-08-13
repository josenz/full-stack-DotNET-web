// ** Microsoft.AspNetCore.Mvc directive was introduced here at this process stage.
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BooksAPI.Services;

namespace BooksAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; set; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BooksDbContext>( o => o.UseSqlServer(Configuration.GetConnectionString("BookConnection")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, BooksDbContext booksDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            booksDbContext.CreateSeedData();

            // app.UseMvc -> this Method from IApplicationBuilder was added here at this process stage.
            app.UseMvc();
        }
    }
}
