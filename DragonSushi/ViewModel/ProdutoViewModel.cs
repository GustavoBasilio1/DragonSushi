using DragonSushi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DragonSushi.ViewModel
{
    public class ProdutoViewModel
    {
        public Produto Produto { get; set; }
        public Categoria Categoria { get; set; }
        public UnMedida UnMedida { get; set; }
        public bool Verificacao = false;
    }
}