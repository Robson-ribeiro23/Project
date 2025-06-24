using Ac;
using Acelera2025.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static EventoModels;

namespace Acelera2025.Views
{
    public partial class OrganizarEvento: Form
    {
        private bool panelVisivel = false;
        private CardPerfil cardPerfil;
        private bool cardPerfilVisivel = false;
        private PessoaModels usuario;
        private CardPainelDeNotificacoes cardPainelDeNotificacoes;
        private bool cardPainelDeNotificacoesVisivel = false;
        public OrganizarEvento(PessoaModels usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            if (!string.IsNullOrEmpty(this.usuario.CaminhoFoto) && File.Exists(this.usuario.CaminhoFoto))
            {
                picturePerfil.Image = Image.FromFile(this.usuario.CaminhoFoto);
            }

        }
        
        private void OrganizarEvento_Load(object sender, EventArgs e)
        {
            panelMeusEventos.Visible = false;
            cardPerfil = new CardPerfil(this.usuario);
            cardPerfil.Visible = false;


            panel1.Controls.Add(cardPerfil);
            cardPerfil.Location = new Point(panel1.Width - cardPerfil.Width - 20, 0);
            cardPerfil.FecharTelaSolicitado += (s, args) => this.Close();
            cardPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            cardPainelDeNotificacoes = new CardPainelDeNotificacoes();
            cardPainelDeNotificacoes.Visible = false;
            panel1.Controls.Add(cardPainelDeNotificacoes);
            cardPainelDeNotificacoes.Location = new Point(gradientPanel1.Width - cardPerfil.Width - 20, 0);
            cardPainelDeNotificacoes.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            string[] estados = { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO",
                     "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR",
                     "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" };

            string[] categorias = { "Artes", "Tecnologia", "Saúde", "Educação", "Festivais", "Música", 
                "Dança", "Ciências", "Competições e Concursos", "Espiritualidade", "Exposições e Feiras",
                "Festas", "Esportes", "Sociedade", "Gastronomia", "Empreendedorismo", "Entretenimento",
                "Voluntariado", "Meio Ambiente" , "Hobbies" };

            string[] faixaEtaria = { "Livre", "+10", "+12",
                "+14", "+16", "+18"
            };

            comboUF.Items.AddRange(estados);
            comboCategoria.Items.AddRange(categorias);
            comboFaixaEtaria.Items.AddRange(faixaEtaria);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnPresencial.Checked)
            {
                panel3.Visible = true;
                panel2.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnOnline.Checked)
            { 
                panel2.Visible = true;
                panel3.Visible = false;
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            try
            {
                // === Salvar imagem do PictureBox ===
                string caminhoImagem = null;
                if (picEvento.Image != null)
                {
                    string pastaDestino = @"C:\Users\giiml\Desktop\Acelera2025\Acelera2025\Pictures";

                    if (!Directory.Exists(pastaDestino))
                        Directory.CreateDirectory(pastaDestino);

                    string nomeArquivo = "evento" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
                    string caminhoCompleto = Path.Combine(pastaDestino, nomeArquivo);

                    picEvento.Image.Save(caminhoCompleto, System.Drawing.Imaging.ImageFormat.Png);

                    caminhoImagem = caminhoCompleto; // Guarda o caminho para passar ao modelo
                }

                // === Dados do formulário ===
                string nomeEvento = txtNomeEvento.Text;
                DateTime dataEvento = dateTimePicker.Value;
                string horario = txtHorario.Text;
                string categoria = comboCategoria.SelectedItem?.ToString();
                bool isPresencial = radioBtnPresencial.Checked;
                int limiteParticipantes = int.TryParse(txtLimiteParticipantes.Text, out int limite) ? limite : 0;
                string faixaEtaria = comboFaixaEtaria.SelectedItem?.ToString();
                string descricao = txtDescricao.Text;
                bool permitePatrocinio = checkBoxPatrocinio.Checked;
                string email = this.usuario.Email;
                string nomeLocal = txtNomeLocal.Text;
                string rua = txtRua.Text;
                string numero = txtNumero.Text;
                string bairro = txtBairro.Text;
                string cep = txtCEP.Text;
                string cidade = txtCidade.Text;





                // === Cria o evento com o caminho da imagem ===
                EventoModels novoEvento = new EventoModels
                (
                    nomeEvento,
                    dataEvento,
                    categoria,
                    horario,
                    isPresencial,
                    limiteParticipantes,
                    faixaEtaria,
                    descricao,
                    permitePatrocinio,
                    caminhoImagem,
                    email,
                    nomeLocal,
                    rua,
                    numero,
                    bairro,
                    cep,
                    cidade
                );

                EventoControllers controller = new EventoControllers();
                bool sucesso = controller.CriarEvento(novoEvento);

                if (sucesso)
                {
                    // Exibe eventos criados no console
                    foreach (var es in controller.ListarTodos())
                    {
                        Console.WriteLine("Salvo: " + es.NomeEvento + " | Imagem: " + es.CaminhoImagem);
                    }

                    // Adiciona à cache (opcional para acessos futuros)
                    EventoCache.Adicionar(novoEvento);

                    Navegador.IrParaTelaEventos(this.usuario, novoEvento);

                    MessageBox.Show("Evento criado com sucesso!");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar evento: " + ex.Message);
            }


           


            /*try
            {

                string nomeEvento = txtNomeEvento.Text;
                DateTime dataEvento = dateTimePicker.Value;
                string horario = txtHorario.Text;
                string categoria = comboCategoria.SelectedItem?.ToString();
                bool isPresencial = radioBtnPresencial.Checked;
                int limiteParticipantes = int.TryParse(txtLimiteParticipantes.Text, out int limite) ? limite : 0;
                string faixaEtaria = comboFaixaEtaria.SelectedItem?.ToString();
                string descricao = txtDescricao.Text;
                bool permitePatrocinio = checkBoxPatrocinio.Checked;



                EventoModels novoEvento = new EventoModels
                (
                    nomeEvento,
                    dataEvento,
                    categoria,
                    horario,
                    isPresencial,
                    limiteParticipantes,
                    faixaEtaria,
                    descricao,
                    permitePatrocinio
                );

                EventoControllers controller = new EventoControllers();
                bool sucesso = controller.CriarEvento(novoEvento);

                if (sucesso)
                {
                    // TESTE: ver se realmente salvou
                    foreach (var es in controller.ListarTodos())
                    {
                        Console.WriteLine("Salvo: " + es.NomeEvento);
                    }

                    //LimparFormulario();
                }

                MessageBox.Show("Evento criado com sucesso!");


                if (picEvento.Image != null)
                {
                    string pastaDestino = @"C:\Users\giiml\Desktop\Acelera2025\Acelera2025\Pictures";

                    if (!Directory.Exists(pastaDestino))
                        Directory.CreateDirectory(pastaDestino);

                    string nomeArquivo = "evento" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
                    string caminhoCompleto = Path.Combine(pastaDestino, nomeArquivo);

                    picEvento.Image.Save(caminhoCompleto, System.Drawing.Imaging.ImageFormat.Png);
                }
            


                    //LimparFormulario();
                }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar evento: " + ex.Message);
            }

            //Navegador.IrParaTelaEventos(this.usuario); */


        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelVisivel = !panelVisivel;
            panelMeusEventos.Visible = panelVisivel;
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            Navegador.IrParaEventosCriados(this.usuario);
        }

        private void btnAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaAjuda(this.usuario);
        }

        private void btnSobreNos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaSobreNos(this.usuario);
        }

        private void btnPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaHome(this.usuario);
        }

        private void picturePerfil_Click(object sender, EventArgs e)
        {
            cardPerfilVisivel = !cardPerfilVisivel;
            cardPerfil.Visible = cardPerfilVisivel;
            cardPerfil.BringToFront();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Navegador.IrParaPesquisa(this.usuario);
        }

        private void btnNotificacoes_Click(object sender, EventArgs e)
        {
            cardPainelDeNotificacoesVisivel = !cardPainelDeNotificacoesVisivel;
            cardPainelDeNotificacoes.Visible = cardPainelDeNotificacoesVisivel;
            cardPainelDeNotificacoes.BringToFront();
        }

        private void btnFeed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador.IrParaFeed(this.usuario);
        }

        public void btnAddImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Selecionar Imagem";
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picEvento.Image = Image.FromFile(openFileDialog.FileName);
                    picEvento.SizeMode = PictureBoxSizeMode.Zoom; // ou StretchImage, CenterImage, etc.
                }
            }
        }

        private void picEvento_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
