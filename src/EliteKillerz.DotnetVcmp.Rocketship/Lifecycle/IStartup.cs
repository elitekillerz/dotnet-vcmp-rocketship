using Microsoft.Extensions.DependencyInjection;

namespace EliteKillerz.DotnetVcmp.Rocketship.Lifecycle
{
    public interface IStartup
    {
        public abstract void ConfigureServices(IServiceCollection services);
    }
}
