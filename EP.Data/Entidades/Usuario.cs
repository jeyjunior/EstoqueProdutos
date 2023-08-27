using EstoqueProdutos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.Data.Entidades
{
    public class Usuario
    {
        public int PK_Usuario { get; set; }
        public string NomeCompleto { get; set; }    
        public string NomeAbreviado { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public int FK_Setor { get; set; }
        public int FK_Cargo { get; set; }
        public int FK_Imagem { get; set; }
        public bool Ativo { get; set; }

        public virtual Setor Setor{ get; set; }
        public virtual Cargo Cargo { get; set; }
        public virtual Imagem Imagem { get; set; }
    }
}

