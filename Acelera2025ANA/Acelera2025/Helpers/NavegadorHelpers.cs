using Acelera2025.Views;
using System.Windows.Forms;

namespace Ac
{
    public static class Navegador
    {
        private static Form telaAtual;

        public static void IrParaHome(PessoaModels usuario)
        {
            FecharTelaAtual();
            telaAtual = new Home(usuario);
            telaAtual.Show();
        }

        public static void IrParaInicio()
        {
            FecharTelaAtual();
            telaAtual = new Inicio(); 
            telaAtual.Show();
        }

        public static void IrParaLoginUsuario()
        {
            FecharTelaAtual();
            telaAtual = new EntrarUsuario();
            telaAtual.Show();
        }

        public static void IrParaLoginEmpresa()
        {
            FecharTelaAtual();
            telaAtual = new EntrarEmpresa();
            telaAtual.Show();
        }
       
        public static void IrParaCadastroUsuario()
        {
            FecharTelaAtual();
            telaAtual = new CadastrarUsuario();
            telaAtual.Show();
        }

        public static void IrParaCadastroEmpresa()
        {
            FecharTelaAtual();
            telaAtual = new CadastrarEmpresa();
            telaAtual.Show();
        }

        public static void IrParaOpcaoLogin()
        {
            FecharTelaAtual();
            telaAtual = new OpcaoLogin();
            telaAtual.Show();
        }

        public static void IrParaCategorias()
        {
            FecharTelaAtual();
            telaAtual = new Categorias();
            telaAtual.Show();
        }

        public static void IrParaPesquisa()
        {
            FecharTelaAtual();
            telaAtual = new Pesquisa();
            telaAtual.Show();
        }

        public static void IrParaSobreNos()
        {
            FecharTelaAtual();
            telaAtual = new SobreNos();
            telaAtual.Show();
        }

        public static void IrParaOrganizarEventos()
        {
            FecharTelaAtual();
            telaAtual = new OrganizarEvento();
            telaAtual.Show();
        }

        public static void IrParaAjuda()
        {
            FecharTelaAtual();
            telaAtual = new Ajuda();
            telaAtual.Show();
        }

        public static void IrParaEventosCriados()
        {
            FecharTelaAtual();
            telaAtual = new EventosCriados();
            telaAtual.Show();
        }

        public static void IrParaTelaEventos()
        {
            FecharTelaAtual();
            telaAtual = new TelaEvento();
            telaAtual.Show();
        }

        public static void IrParaPerfilEmpresa(PessoaModels usuario)
        {
            FecharTelaAtual();
            telaAtual = new PerfilEmpresa(usuario);
            telaAtual.Show();
        }

        public static void IrParaPerfilUsuario(PessoaModels usuario)
        {
            FecharTelaAtual();
            telaAtual = new Perfil(usuario);
            telaAtual.Show();
        }



        private static void FecharTelaAtual()
        {
            if (telaAtual != null && !telaAtual.IsDisposed)
            {
                telaAtual.Hide();
            }
        }







    }
}
