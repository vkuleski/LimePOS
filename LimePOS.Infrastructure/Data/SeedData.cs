using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace LimePOS.Infrastructure.Data
{
    public static class SeedData
    {

        public static void Initialize(IServiceProvider services)
        {
            //var context = services.GetRequiredService<ApplicationDbContext>();
            //context.Database.Migrate();
        }
    }
}