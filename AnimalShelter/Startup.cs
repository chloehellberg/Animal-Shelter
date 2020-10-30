using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using AnimalShelter.Models;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter
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
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Animal Shelter", Version = "v1" });
      });

      services.AddDbContext<AnimalShelterContext>(opt =>
          opt.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
      
      services.AddApiVersioning(x => {
        x.ReportApiVersions = true;
        x.AssumeDefaultVersionWhenUnspecified = true;
        x.DefaultApiVersion = new ApiVersion(1, 0);
        });
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseHsts();
      }

      app.UseMvc();
      app.UseSwagger();
      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Animal Shelter V1");
      });
    }
  }
}
