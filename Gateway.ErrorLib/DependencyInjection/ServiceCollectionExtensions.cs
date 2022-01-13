using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Gateway.ErrorLib.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGatewayErrorCheck(this IServiceCollection services)
        {
            services.AddSingleton<IGatewayErrorCheck, GatewayErrorCheck>();

            return services;
        }
    }
}
