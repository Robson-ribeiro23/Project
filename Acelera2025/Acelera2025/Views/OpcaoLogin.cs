using Ac;
using System;
using System.Windows.Forms;

namespace Acelera2025.Views
{
    public partial class OpcaoLogin : Form
    {
        public OpcaoLogin()
        {
            InitializeComponent();
            panel1.Resize += panel1_Resize;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            int espaco = 45;
            int larguraBotao = 100;
            int larguraDisponivel = Math.Max(0, panel1.ClientSize.Width - (2 * larguraBotao) - (3 * espaco));
            int larguraPainel = larguraDisponivel / 2;

            roundedPanel1.Width = roundedPanel2.Width = larguraPainel;
            roundedPanel1.Left = larguraBotao + espaco;
            roundedPanel2.Left = roundedPanel1.Right + espaco;
        }

        private void btnEntrarEmpresa_Click(object sender, EventArgs e)
        {
            Navegador.IrParaLoginEmpresa();
        }

        private void btnEntrarUsuario_Click(object sender, EventArgs e)
        {
            Navegador.IrParaLoginUsuario();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Navegador.IrParaInicio();
        }

        private void cadastrarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaCadastroUsuario();
        }

        private void cadastrarEmpresa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaCadastroEmpresa();
        }
    }
}
