using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebSocketServer.Middleware
{
    public static class WebSocketServerMiddlewareExtensions
    {
        public static IApplicationBuilder UseWebSocketServer(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<WebSocketServerMiddleware>();
        }

        public static IServiceCollection AddWebSocketServerConnectionManager(this IServiceCollection services)
        {
            //Look at Service Lifetimes in .Net Core Fundametal Documentation
            //services.AddTransient<WebSocketServerConnectionManager>();
            services.AddSingleton<WebSocketServerConnectionManager>();
            return services;
        }
    }

    
}