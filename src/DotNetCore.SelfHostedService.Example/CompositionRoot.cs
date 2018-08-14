namespace DotNetCore.SelfHostedService.Example
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public static class CompositionRoot
    {
        public static void ComposeApplication(
            IServiceCollection services,
            IConfiguration configuration,
            IHostingEnvironment environment)
        {
            services.AddOptions();
            services.AddHostedService<Service>();
        }
    }
}
