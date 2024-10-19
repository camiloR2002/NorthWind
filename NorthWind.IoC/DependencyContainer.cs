using Microsoft.Extensions.DependencyInjection;
using NMicrosoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Writers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddNorthWindServices(this IServiceCollection services)
        {
            services.AddDebugWriter();
            services.AddServices();
            return services;
        }
    }
}
