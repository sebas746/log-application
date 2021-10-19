using LogApplication.Core.Logger;
using Microsoft.Extensions.DependencyInjection;

namespace LogApplication.WebApi.Helpers
{
    public class DependencyInjectionHelper
    {
        protected DependencyInjectionHelper() { }

        public static void ConfigureDependencies(IServiceCollection services)
        {
            services.AddSingleton<Microsoft.AspNetCore.Http.IHttpContextAccessor, Microsoft.AspNetCore.Http.HttpContextAccessor>();
            services.AddSingleton<ILoggerService, LoggerService>();
        }
    }
}
