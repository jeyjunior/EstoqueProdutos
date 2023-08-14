using EstoqueProdutos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;

namespace EP.Data.Interfaces
{
    public interface IImagemRepositorio
    {
        public void SalvarImagemPadraoLocalTemporario();
        public Image? ProcurarImagemLocal();
        public bool SalvarImagem();
        public Imagem ObterObjetoImagemPadrao();
        public Image ObterImagemPadrao();
    }
}
