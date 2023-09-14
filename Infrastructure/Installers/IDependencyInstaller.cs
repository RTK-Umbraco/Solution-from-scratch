using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Installers;
internal interface IDependencyInstaller
{
    void Install(IServiceCollection serviceCollection, DependencyInstallerOptions options);
}
