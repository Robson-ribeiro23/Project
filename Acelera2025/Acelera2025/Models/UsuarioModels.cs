using System.Collections.Generic;
using Acelera2025.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Acelera2025.Models
{
    public class UsuarioModels : PessoaModels
    {
        public string CPF { get; set; }
        public string DataNascimento { get; set; }

        public List<UsuarioModels> Seguindo { get; set; } = new List<UsuarioModels>();
        public List<UsuarioModels> Seguidores { get; set; } = new List<UsuarioModels>();

        public bool EstaSeguindo(UsuarioModels outro)
        {
            return Seguindo.Any(u => u.Email == outro.Email);
        }

        public bool SeguirOuDeixarDeSeguir(UsuarioModels outro)
        {
            if (EstaSeguindo(outro))
            {
                Seguindo.RemoveAll(u => u.Email == outro.Email);
                outro.Seguidores.RemoveAll(u => u.Email == this.Email);
                return false;
            }
            else
            {
                Seguindo.Add(outro);
                outro.Seguidores.Add(this);
                return true;
            }
        }
    }
}

