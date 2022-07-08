using DesafioFinal_Dot_NET.Data;
using Microsoft.EntityFrameworkCore;

namespace DesafioFinal_Dot_NET
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get;  }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddEntityFrameworkSqlServer()
            .AddDbContext<Contexto>(o => o.UseSqlServer(Configuration.GetConnectionString("DataBase")));
            
        }
        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {

        }
    }
}
