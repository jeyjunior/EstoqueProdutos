using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Repositorios;
using SimpleInjector;

namespace EstoqueProdutos.Gerenciamento
{
    /// <summary>
    /// Configuração da Injeção de Dependencia
    /// </summary>
    public static class ConfiguradorDI
    {
        private static readonly Container _container;

        static ConfiguradorDI()
        {
            _container = new Container();
            _container.Register(typeof(IRepositorio<>), typeof(Repositorio<>));
            _container.RegisterSingleton<CategoriaRepositorio>();
            _container.RegisterSingleton<EmbalagemRepositorio>();
            _container.RegisterSingleton<FormatoRepositorio>();
            _container.RegisterSingleton<ImagemRepositorio>();
            _container.RegisterSingleton<MarcaRepositorio>();
            _container.RegisterSingleton<ProdutoRepositorio>();
            _container.RegisterSingleton<UnidadeMedidaRepositorio>();
            _container.Options.ResolveUnregisteredConcreteTypes = true;
            _container.Verify();
        }

        public static Container Container => _container;

    }
}
