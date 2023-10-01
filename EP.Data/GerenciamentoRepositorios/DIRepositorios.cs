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
            _container.Register(typeof(IRepositorio<>), typeof(RepositorioGenerico<>));
            _container.RegisterSingleton<IImagemRepositorio ,ImagemRepositorio>();
            _container.RegisterSingleton<IProdutoRepositorio, ProdutoRepositorio>();
            _container.RegisterSingleton<IMarcaRepositorio, MarcaRepositorio>();
            _container.RegisterSingleton<ICategoriaRepositorio, CategoriaRepositorio>();
            _container.RegisterSingleton<IFormatoRepositorio, FormatoRepositorio>();
            _container.RegisterSingleton<IEmbalagemRepositorio, EmbalagemRepositorio>();
            _container.RegisterSingleton<IUnidadeMedidaRepositorio, UnidadeMedidaRepositorio>();
            _container.RegisterSingleton<ISetorRepositorio, SetorRepositorio>();
            _container.RegisterSingleton<ICargoRepositorio, CargoRepositorio>();
            _container.RegisterSingleton<IUsuarioRepositorio, UsuarioRepositorio>();
            _container.RegisterSingleton<IConfigColunasProdutoRepositorio, ConfigColunasProdutoRepositorio>();

            _container.Options.ResolveUnregisteredConcreteTypes = true;
            _container.Verify();
        }

        public static Container Container => _container;
    }
}
