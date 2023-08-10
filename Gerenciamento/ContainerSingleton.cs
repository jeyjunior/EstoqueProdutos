using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Repositorios;
using EstoqueProdutos.Telas_Produto;
using SimpleInjector;

namespace EstoqueProdutos.Gerenciamento
{
    public class ContainerSingleton
    {
        private static Container _instancia;
        public static Container Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Container();
                    _instancia.Register(typeof(IRepositorio<>), typeof(Repositorio<>));
                    _instancia.Register<CategoriaRepositorio>();
                    _instancia.Register<EmbalagemRepositorio>();
                    _instancia.Register<FormatoRepositorio>();
                    _instancia.Register<ImagemRepositorio>();
                    _instancia.Register<MarcaRepositorio>();
                    _instancia.Register<ProdutoRepositorio>();
                    _instancia.Register<UnidadeMedidaRepositorio>();
                    _instancia.Options.ResolveUnregisteredConcreteTypes = true;
                    _instancia.Verify();
                }
                return _instancia;
            }
        }

        public static T ObterFormComDependencias<T>() where T : Form
        {
            return Instancia.GetInstance<T>();
        }
    }
}
