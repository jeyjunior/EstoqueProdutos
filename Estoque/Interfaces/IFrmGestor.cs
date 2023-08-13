using EstoqueProdutos.Telas_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Interfaces
{
    public interface IFrmGestor
    {
        //void AbrirFilho<T>() where T : FrmBase, IFrmBase, new();
        void FecharFilho(Type tipoClasseHerdeira);
        //void FecharFilho<T>() where T : FrmBase, IFrmBase;
    }
}
