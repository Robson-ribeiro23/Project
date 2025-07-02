using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Ac;
using Acelera2025.Models;
using Acelera2025.Presença;
using Acelera2025.Telas;
using Acelera2025.Utils;
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

            /*comboCategoria.SelectedIndex = 0;
            radioBtnPresencial.Checked = true;
            comboFaixaEtaria.SelectedIndex = 0;*/
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
                // === Validações ===
                if (txtNomeEvento.Text.Length > 30)
                {
                    MessageBox.Show("O nome do evento deve conter no máximo 30 caracteres.");
                    return;
                }

                if (dateTimePicker.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("A data do evento não pode ser anterior à data atual.");
                    return;
                }

                if (!TimeSpan.TryParse(txtHorario.Text, out TimeSpan horarioValido))
                {
                    MessageBox.Show("Horário inválido. Use o formato HH:mm.");
                    return;
                }

                if (!int.TryParse(txtLimiteParticipantes.Text, out int limite))
                {
                    MessageBox.Show("Limite de participantes inválido.");
                    return;
                }

                bool isEmpresa = usuario.Tipo == "empresa"; // Ajuste se necessário conforme sua lógica
                int limiteMaximo = isEmpresa ? 1000 : 200;
                if (limite > limiteMaximo)
                {
                    MessageBox.Show($"Limite de participantes não pode ultrapassar {limiteMaximo}.");
                    return;
                }

                if (txtDescricao.Text.Length > 2000)
                {
                    MessageBox.Show("A descrição não pode ultrapassar 2000 caracteres.");
                    return;
                }

                if (radioBtnOnline.Checked)
                {
                    if (!string.IsNullOrWhiteSpace(txtLinkReunião.Text))
                    {
                        if (!Uri.IsWellFormedUriString(txtLinkReunião.Text, UriKind.Absolute))
                        {
                            MessageBox.Show("Link da reunião inválido.");
                            return;
                        }
                    }
                }

                int numero = 0;

                if (radioBtnPresencial.Checked) 
                { 
                    if (txtCidade.Text.Length > 20 || !txtCidade.Text.All(char.IsLetter))
                    {
                        MessageBox.Show("A cidade deve conter apenas letras e no máximo 20 caracteres.");
                        return;
                    }

                    if (txtLocal.Text.Length > 30)
                    {
                        MessageBox.Show("O local deve conter no máximo 30 caracteres.");
                        return;
                    }

                    if (!System.Text.RegularExpressions.Regex.IsMatch(txtCep.Text, @"^\d{5}-\d{3}$"))
                    {
                        MessageBox.Show("CEP inválido. Use o formato 00000-000.");
                        return;
                    }

                    if (txtBairro.Text.Length > 40)
                    {
                        MessageBox.Show("O bairro deve conter no máximo 40 caracteres.");
                        return;
                    }

                    if (!int.TryParse(txtNumero.Text, out numero) || numero > 1000)
                    {
                        MessageBox.Show("Número inválido. O valor máximo permitido é 1000.");
                        return;
                    }

                    if (txtNomeRua.Text.Length > 30)
                    {
                        MessageBox.Show("O nome da rua deve conter no máximo 30 caracteres.");
                        return;
                    }
                }

                // === Salvar imagem do PictureBox ===
                string caminhoImagem = null;
                if (picEvento.Image != null)
                {
                    //string pastaDestino = @"C:\Users\giiml\Desktop\Acelera2025\Acelera2025\Pictures";
                    string pastaDestino = @"C:\Users\amand\OneDrive\Comuna\Documentos\GitHub\Project\Acelera2025\Acelera2025\Pictures";

                    if (!Directory.Exists(pastaDestino))
                        Directory.CreateDirectory(pastaDestino);

                    string nomeArquivo = "evento" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
                    string caminhoCompleto = Path.Combine(pastaDestino, nomeArquivo);

                    picEvento.Image.Save(caminhoCompleto, System.Drawing.Imaging.ImageFormat.Png);
                    caminhoImagem = caminhoCompleto;
                }

                // === Dados do formulário ===
                string nomeEvento = txtNomeEvento.Text;
                DateTime dataEvento = dateTimePicker.Value;
                string horario = txtHorario.Text;
                string categoria = comboCategoria.SelectedItem?.ToString();
                bool isPresencial = radioBtnPresencial.Checked;
                int limiteParticipantes = limite;
                string faixaEtaria = comboFaixaEtaria.SelectedItem?.ToString();
                string descricao = txtDescricao.Text;
                bool permitePatrocinio = checkBoxPatrocinio.Checked;
                string email = this.usuario.Email;

                string local = txtLocal.Text;
                string rua = txtNomeRua.Text;
                string bairro = txtBairro.Text;
                string cep = txtCep.Text;
                string cidade = txtCidade.Text;
                string estado = comboUF.SelectedItem?.ToString();
                string linkReuniao = isPresencial ? null : txtLinkReunião.Text;
                string codigoPresenca = GeradorDeCodigos.Gerar(8);
                ControleDePresencas.RegistrarCodigo(codigoPresenca);

                EventoModels novoEvento = new EventoModels(
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
                    local,
                    rua,
                    numero.ToString(),
                    bairro,
                    cep,
                    cidade,
                    estado,
                    linkReuniao
                );

                novoEvento.CodigoPresenca = codigoPresenca;

                EventoControllers controller = new EventoControllers();
                bool sucesso = controller.CriarEvento(novoEvento);

                if (sucesso)
                {
                    novoEvento.criador = usuario;
                    EventoCache.Adicionar(novoEvento);
                    MessageBox.Show($"Evento criado com sucesso!\\n\\nCódigo de Presença: {novoEvento.CodigoPresenca}");

                    List<PessoaModels> seguidores = usuario.Seguidores;

                    var context = new Dictionary<string, object>();
                    context["perfil"] = usuario;
                    context["evento"] = novoEvento;
                    foreach (PessoaModels follower in seguidores)
                    {
                        NotificacaoModels notificacao = new NotificacaoModels(follower.Email, "onAccountEvent", context);
                        NotificacaoCache.AdicionarNotificacao(follower.Email, notificacao);
                    }

                    Navegador.IrParaTelaEventos(this.usuario, novoEvento);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar evento: " + ex.Message);
            }
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

        private void btnEventosIngressados_Click(object sender, EventArgs e)
        {
            Navegador.IrParaEventosIngressados(this.usuario);
        }
    }
}
