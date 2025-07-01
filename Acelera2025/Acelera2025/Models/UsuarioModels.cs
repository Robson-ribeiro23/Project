using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using Acelera2025.Models;

namespace Acelera2025.Models
{
    public class UsuarioModels : PessoaModels
    {
        public string CPF { get; set; }
        public string DataNascimento { get; set; }

        
    }
}

