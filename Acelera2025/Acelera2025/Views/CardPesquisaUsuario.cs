﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ac;
using Acelera2025.Views;

namespace Acelera2025.Telas
{
    public partial class CardPesquisaUsuario: UserControl
    {
        private PessoaModels usuario;
        private EventoModels evento;

        public CardPesquisaUsuario()
        {
            InitializeComponent();

            lblNome.Click += lblNome_Click;
        }

        public void DefinirDadosUsuario(PessoaModels usuario)
        {
            this.usuario = usuario;

            lblNome.Text = usuario.Nome;


            if (!string.IsNullOrEmpty(usuario.CaminhoFoto) && File.Exists(usuario.CaminhoFoto))
            {
                picPerfil.Image = Image.FromFile(usuario.CaminhoFoto);
            }
        }

        public void DefinirDadosEvento(EventoModels evento)
        {
            this.evento = evento;

            lblNome.Text = evento.NomeEvento;
            if (!string.IsNullOrEmpty(evento.CaminhoImagem) && File.Exists(evento.CaminhoImagem))
            {
                picPerfil.Image = Image.FromFile(evento.CaminhoImagem);
            }
        }

        public void ForçarUsuario(PessoaModels usuario)
        {
            this.usuario = usuario;
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            if (evento != null)
            {
                Navegador.IrParaTelaEventos(this.usuario, evento);
            }
            else if (usuario != null)
            {
                if (usuario.Tipo == "Empresa")
                {
                    Navegador.IrParaPerfilEmpresa(usuario);
                }
                else
                {
                    Navegador.IrParaPerfilUsuario(usuario);
                }
            }
        }

        private void CardPesquisaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void lblNome_Click_1(object sender, EventArgs e)
        {

        }
    }
}
