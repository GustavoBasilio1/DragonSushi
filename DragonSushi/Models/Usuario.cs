﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DragonSushi.Models
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public int fkPessoa { get; set; }
    }
}