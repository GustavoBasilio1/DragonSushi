using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DragonSushi.Models
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public int qtdProd { get; set; }
        public string descrPedido { get; set; }
        public int fkProd { get; set; }
        public int fkComanda { get; set; }
    }
}