using DragonSushi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DragonSushi.ViewModel
{
    public class EnderecoViewModel
    {
        public Endereco Endereco { get; set; }
        public Rua Rua { get; set; }
        public Bairro Bairro { get; set; }
        public Cidade Cidade { get; set; }
        public Estado Estado { get; set; }
    }
}