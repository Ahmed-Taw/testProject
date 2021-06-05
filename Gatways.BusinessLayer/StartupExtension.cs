using Gatways.BusinessLayer.Infrastructure.IServices;
using Gatways.BusinessLayer.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gatways.BusinessLayer
{
    public static class StartupExtension
    {
        public static void AddBusinessLayerServices(this IServiceCollection services)
        {
            services.AddScoped<IGatewayService, GatewayService>();
        }
    }
}
