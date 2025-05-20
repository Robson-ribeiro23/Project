using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025.Telas
{
    public partial class Pesquisa: Form
    {
        public Pesquisa()
        {
            InitializeComponent();
        }

        private void btnPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {
            string[] estados = { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO",
                     "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR",
                     "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };

            comboUF.Items.AddRange(estados);
            comboFiltrarBusca.Items.Add("Eventos");
            comboFiltrarBusca.Items.Add("Empresas");
            comboFiltrarBusca.Items.Add("Pessoas");
        }
    }
}
