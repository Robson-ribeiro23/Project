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

        public static void IrParaCategorias(PessoaModels usuario)
        {
            FecharTelaAtual();
            telaAtual = new Categorias(usuario);
            telaAtual.Show();
        }

        public static void IrParaCategoriaSelecionada(PessoaModels usuario, string categoria)
        {
            FecharTelaAtual();
            telaAtual = new CategoriaSelecionada(usuario, categoria);
            telaAtual.Show();
        }

        public static void IrParaPesquisa(PessoaModels usuario)
        {
            FecharTelaAtual();
            telaAtual = new Pesquisa(usuario);
            telaAtual.Show();
        }

        public static void IrParaSobreNos(PessoaModels usuario)
        {
            FecharTelaAtual();
            telaAtual = new SobreNos(usuario);
            telaAtual.Show();
        }

        public static void IrParaOrganizarEventos(PessoaModels usuario)
        {
            FecharTelaAtual();
            telaAtual = new OrganizarEvento(usuario);
            telaAtual.Show();
        }

        public static void IrParaAjuda(PessoaModels usuario)
        {
            FecharTelaAtual();
            telaAtual = new Ajuda(usuario);
            telaAtual.Show();
        }

        public static void IrParaEventosCriados(PessoaModels usuario)
        {
            FecharTelaAtual();
            telaAtual = new EventosCriados(usuario);
            telaAtual.Show();
        }

        public static void IrParaTelaEventos(PessoaModels usuario)
        {
            FecharTelaAtual();
            telaAtual = new TelaEvento(usuario, null); // passa null como evento
            telaAtual.Show();
        }

        public static void IrParaTelaEventos(PessoaModels usuario, EventoModels evento)
        {
            FecharTelaAtual();
            telaAtual = new TelaEvento(usuario, evento); // <-- evento passado corretamente
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

        public static void IrParaEventosIngressados(PessoaModels usuario)
        {
            FecharTelaAtual();
            telaAtual = new EventosIngressados(usuario);
            telaAtual.Show();
        }
        public static void IrParaFeed(PessoaModels usuario)
        {
            FecharTelaAtual();
            telaAtual = new Feed(usuario);
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
