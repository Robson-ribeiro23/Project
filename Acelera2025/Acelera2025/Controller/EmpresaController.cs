using System.Collections.Generic;
using Acelera2025.Model;
using Acelera2025.Service;

namespace MeuSistema.Controller
{
    public class EmpresaController
    {
        private EmpresaService empresaService = new EmpresaService();

        public EmpresaModel CadastrarEmpresa(string nome, string cnpj, string telefone, string email, string senha)
        {
            EmpresaModel novaEmpresa = new EmpresaModel
            {
                Nome = nome,
                CNPJ = cnpj,
                Telefone = telefone,
                Email = email,
                Senha = senha
            };

            return empresaService.Cadastrar(novaEmpresa);
        }
        public EmpresaModel LoginEmpresa(string cnpj, string email, string senha)
        {
            return empresaService.Login(cnpj, email, senha);
        }

        public List<EmpresaModel> ListarEmpresas()
        {
            return empresaService.Listar();
        }
    }
}
