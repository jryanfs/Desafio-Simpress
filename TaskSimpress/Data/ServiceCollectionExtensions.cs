using DesafioSimpress.Repositories;
using DesafioSimpress.Repositories.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioSimpress.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInternalRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<ICategoriaProdutoRepository, CategoriaProdutoRepository>();

            return services;
        }
    }
}