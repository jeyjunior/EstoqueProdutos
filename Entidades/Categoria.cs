﻿using EstoqueProdutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Entidades
{
    public class Categoria : IEntidade
    {
        public int PK_Categoria { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
    }
}
 