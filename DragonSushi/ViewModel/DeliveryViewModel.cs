using DragonSushi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DragonSushi.ViewModel
{
    public class DeliveryViewModel
    {
        public Pessoa Pessoa { get; set; }
        public Endereco Endereco { get; set; }
        public Comanda Comanda { get; set; }
        public Pagamento Pagamento { get; set; }
        public FormaPg FormaPg { get; set; }
    }
}