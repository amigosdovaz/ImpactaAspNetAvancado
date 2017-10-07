﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Empresa.Dominio
{
    public class Contato
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }

        public string Email { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
    }
}
