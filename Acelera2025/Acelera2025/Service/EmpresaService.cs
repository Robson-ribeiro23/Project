using Acelera2025.Model;
using System.Collections.Generic;

namespace Acelera2025.Service
{
    public class EmpresaService
    {
        private static List<EmpresaModel> empresas = new List<EmpresaModel>();
        private static int proximoId = 1;

        public EmpresaModel Cadastrar(EmpresaModel empresa)
        {
            empresa.Id = proximoId++;
            empresas.Add(empresa);
            return empresa;
        }

        public EmpresaModel Login(string cnpj, string email, string senha)
        {
            return empresas.Find(e => e.CNPJ == cnpj && e.Email == email && e.Senha == senha);
        }

        public List<EmpresaModel> Listar()
        {
            return empresas;
        }
    }
}
