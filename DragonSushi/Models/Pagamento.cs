﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DragonSushi.Models
{
    public class Pagamento
    {
        public int idPag { get; set; }
        public decimal total { get; set; }
        public int fkFormaPag { get; set; }
    }
}