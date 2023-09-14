using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Installers;
public sealed class ServiceInstaller : IDependencyInstaller
{
    public void Install(IServiceCollection serviceCollection, DependencyInstallerOptions options)
    {
        serviceCollection.AddTransient<>
    }
}
