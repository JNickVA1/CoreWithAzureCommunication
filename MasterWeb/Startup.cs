using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MasterWeb
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTQzQDMxMzYyZTMyMmUzMFVXZThEK2RiVjhQeFJ6Vlh6MzA5TzR4T0V0MW9FWjNNYlZ6SHY0T3dRQms9;NTQ0QDMxMzYyZTMyMmUzMFA2b0R2Vy9PN2lFRmlmUDJ5SGhmN1JTVjFBZytmVEYzN1YxRFBvWEN2cFk9;NTQ1QDMxMzYyZTMyMmUzMGZ4MTA2VjJGTmV3VDBaNTdaWlRTZlhnRy9nTWRuOFlRN2YySzNuREltN1k9;NTQ2QDMxMzYyZTMyMmUzMEkvVmxHZDQvWnZEY2c2TWV0UnR4N1N2TURuM0FpUThwakU3S0ROdmZGYkU9;NTQ3QDMxMzYyZTMyMmUzMEpYcU5ocG1wYU9rSHpJMk5ZVTJGU2pVV0FldGlZelRIdXhRcm5adkJiUnM9;NTQ4QDMxMzYyZTMyMmUzMGN5d2YwNTk4VUVaZlBBNk5LdUQ2MVVVWllhaTdGcE0rM0JiZmo4cUd2SlU9;NTQ5QDMxMzYyZTMyMmUzMFlCMWlnZ3F3Um5sV3lDMmpKa0RMQi9JemYyM2xYU3hLTTQ4QnkxdFEyTnc9;NTUwQDMxMzYyZTMyMmUzMEcza2hNalZZeDBXdXJUNkdzNE5ZSURyOEdWbS9HTmdUWmxNU3JaN3ZTU0k9;NTUxQDMxMzYyZTMyMmUzMFN6am45eXBGNTBManNoeTZocmlBc1hvdXFpQzEyRjFna1VRYjJNQzdrRFU9");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();
        }
    }
}
