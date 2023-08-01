using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;

namespace EstoqueProdutos.Gerenciamento
{
    public class Telas
    {
        private static Telas instance = new Telas();
        public static Telas Instance = instance ??= new Telas();

        Container container;

        private Telas()
        {
            container = new Container();

            
        }

    }


    public enum SubTelaProduto
    {
        Cadastro,
        Pesquisa,
        Editar
    }
}
