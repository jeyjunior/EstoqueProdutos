using EP.Data.Interfaces;
using Estoque.Interfaces;
using Estoque.Telas_Principal;
using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Repositorios;
using EstoqueProdutos.Telas_Principal;
using SimpleInjector;

namespace EstoqueProdutos.Gerenciamento
{
    /// <summary>
    /// Configuração da Injeção de Dependencia
    /// </summary>
    public static class DITelas
    {
        private static readonly Container _container;

        static DITelas()
        {
            _container = new Container();
            _container.RegisterSingleton<IUCPrincipalBot, UCPrincipalBot>();
            _container.RegisterSingleton<IUCPrincipalTop, UCPrincipalTop>();
            _container.RegisterSingleton<IUCPrincipalRight, UCPrincipalRight>();

            _container.Options.ResolveUnregisteredConcreteTypes = true;
            _container.Verify();
        }

        public static Container Container => _container;
    }
}
