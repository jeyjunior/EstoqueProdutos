using EP.Data.Interfaces;
using EP.Data.Repositorios;
using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Repositorios;
using SimpleInjector;

namespace EstoqueProdutos.Gerenciamento
{
    /// <summary>
    /// Configuração da Injeção de Dependencia
    /// </summary>
    public static class DIRepositorios
    {
        private static readonly Container _container;

        static DIRepositorios()
        {
            _container = new Container();
            _container.Register(typeof(IRepositorio<>), typeof(Repositorio<>));
            _container.RegisterSingleton<IImagemRepositorio ,ImagemRepositorio>();
            _container.RegisterSingleton<IProdutoRepositorio, ProdutoRepositorio>();
            _container.RegisterSingleton<CategoriaRepositorio>();
            _container.RegisterSingleton<EmbalagemRepositorio>();
            _container.RegisterSingleton<FormatoRepositorio>();
            _container.RegisterSingleton<MarcaRepositorio>();
            _container.RegisterSingleton<UnidadeMedidaRepositorio>();
            _container.RegisterSingleton<SetorRepositorio>();
            _container.RegisterSingleton<UsuarioRepositorio>();
            _container.RegisterSingleton<CargoRepositorio>();
            _container.Options.ResolveUnregisteredConcreteTypes = true;
            _container.Verify();
        }

        public static Container Container => _container;
    }
}
