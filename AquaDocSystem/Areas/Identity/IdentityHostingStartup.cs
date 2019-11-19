using System;
using AquaDocSystem.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AquaDocSystem.Web.Areas.Identity.IdentityHostingStartup))]
namespace AquaDocSystem.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AquaDocSystemWebLoginContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AquaDocSystemWebLoginContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AquaDocSystemWebLoginContext>();
            });
        }
    }
}