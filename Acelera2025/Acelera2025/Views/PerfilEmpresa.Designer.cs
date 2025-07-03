using Acelera2025.Ferramentas;

namespace Acelera2025.Views
{
    partial class PerfilEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilEmpresa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPerfilEmpresa = new Acelera2025.Views.Tools.CircularPictureBox();
            this.btnLapis = new CircularButton();
            this.panelMeusEventos = new RoundedPanel();
            this.btnEventosCriados = new RoundedButton();
            this.btnEventosIngressados = new RoundedButton();
            this.superiorRoundedPanel1 = new SuperiorRoundedPanel();
            this.lblNumSeguidores = new System.Windows.Forms.Label();
            this.tabControlEndereço = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntrarEmContato = new CircularButton();
            this.btnSeguir = new CircularButton();
            this.lblSeguidores = new System.Windows.Forms.Label();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.gradientPanel1 = new GradientPanel();
            this.btnFeed = new System.Windows.Forms.LinkLabel();
            this.picturePerfil = new Acelera2025.Views.Tools.CircularPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrincipal = new System.Windows.Forms.LinkLabel();
            this.btnNotificacoes = new System.Windows.Forms.Button();
            this.roundedPanel5 = new RoundedPanel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnOrganizarEventos = new System.Windows.Forms.LinkLabel();
            this.btnMeusEventos = new System.Windows.Forms.LinkLabel();
            this.btnAjuda = new System.Windows.Forms.LinkLabel();
            this.btnSobreNos = new System.Windows.Forms.LinkLabel();
            this.lblEnderecoCompleto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfilEmpresa)).BeginInit();
            this.panelMeusEventos.SuspendLayout();
            this.superiorRoundedPanel1.SuspendLayout();
            this.tabControlEndereço.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundedPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblEnderecoCompleto);
            this.panel1.Controls.Add(this.picPerfilEmpresa);
            this.panel1.Controls.Add(this.btnLapis);
            this.panel1.Controls.Add(this.panelMeusEventos);
            this.panel1.Controls.Add(this.superiorRoundedPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 542);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picPerfilEmpresa
            // 
            this.picPerfilEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.picPerfilEmpresa.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picPerfilEmpresa.BorderColor = System.Drawing.Color.Transparent;
            this.picPerfilEmpresa.BorderColor2 = System.Drawing.Color.Transparent;
            this.picPerfilEmpresa.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picPerfilEmpresa.BorderSize = 1;
            this.picPerfilEmpresa.GradientAngle = 50F;
            this.picPerfilEmpresa.Image = global::Acelera2025.Properties.Resources.icons8_test_account_48__1_;
            this.picPerfilEmpresa.Location = new System.Drawing.Point(92, 331);
            this.picPerfilEmpresa.Name = "picPerfilEmpresa";
            this.picPerfilEmpresa.Size = new System.Drawing.Size(125, 125);
            this.picPerfilEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerfilEmpresa.TabIndex = 68;
            this.picPerfilEmpresa.TabStop = false;
            // 
            // btnLapis
            // 
            this.btnLapis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.btnLapis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLapis.BorderColor = System.Drawing.Color.Black;
            this.btnLapis.BorderSize = 0;
            this.btnLapis.Image = global::Acelera2025.Properties.Resources.icons8_edit_100;
            this.btnLapis.Location = new System.Drawing.Point(211, 343);
            this.btnLapis.Name = "btnLapis";
            this.btnLapis.Size = new System.Drawing.Size(24, 21);
            this.btnLapis.TabIndex = 67;
            this.btnLapis.UseVisualStyleBackColor = false;
            this.btnLapis.Click += new System.EventHandler(this.btnLapis_Click);
            // 
            // panelMeusEventos
            // 
            this.panelMeusEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMeusEventos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMeusEventos.BorderColor = System.Drawing.Color.Black;
            this.panelMeusEventos.BorderRadius = 20;
            this.panelMeusEventos.BorderSize = 0;
            this.panelMeusEventos.Controls.Add(this.btnEventosCriados);
            this.panelMeusEventos.Controls.Add(this.btnEventosIngressados);
            this.panelMeusEventos.Location = new System.Drawing.Point(868, 255);
            this.panelMeusEventos.Margin = new System.Windows.Forms.Padding(2);
            this.panelMeusEventos.Name = "panelMeusEventos";
            this.panelMeusEventos.Size = new System.Drawing.Size(184, 81);
            this.panelMeusEventos.TabIndex = 65;
            this.panelMeusEventos.Visible = false;
            // 
            // btnEventosCriados
            // 
            this.btnEventosCriados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEventosCriados.BorderColor = System.Drawing.Color.Black;
            this.btnEventosCriados.BorderRadius = 20;
            this.btnEventosCriados.BorderSize = 0;
            this.btnEventosCriados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventosCriados.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventosCriados.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEventosCriados.Location = new System.Drawing.Point(0, 40);
            this.btnEventosCriados.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventosCriados.Name = "btnEventosCriados";
            this.btnEventosCriados.Size = new System.Drawing.Size(184, 41);
            this.btnEventosCriados.TabIndex = 1;
            this.btnEventosCriados.Text = "Eventos Criados";
            this.btnEventosCriados.UseVisualStyleBackColor = false;
            // 
            // btnEventosIngressados
            // 
            this.btnEventosIngressados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEventosIngressados.BorderColor = System.Drawing.Color.Black;
            this.btnEventosIngressados.BorderRadius = 20;
            this.btnEventosIngressados.BorderSize = 0;
            this.btnEventosIngressados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventosIngressados.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventosIngressados.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEventosIngressados.Location = new System.Drawing.Point(0, 2);
            this.btnEventosIngressados.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventosIngressados.Name = "btnEventosIngressados";
            this.btnEventosIngressados.Size = new System.Drawing.Size(184, 45);
            this.btnEventosIngressados.TabIndex = 0;
            this.btnEventosIngressados.Text = "Eventos Ingressados";
            this.btnEventosIngressados.UseVisualStyleBackColor = false;
            // 
            // superiorRoundedPanel1
            // 
            this.superiorRoundedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superiorRoundedPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.superiorRoundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.superiorRoundedPanel1.BorderRadius = 100;
            this.superiorRoundedPanel1.BorderSize = 0;
            this.superiorRoundedPanel1.Controls.Add(this.lblNumSeguidores);
            this.superiorRoundedPanel1.Controls.Add(this.tabControlEndereço);
            this.superiorRoundedPanel1.Controls.Add(this.label3);
            this.superiorRoundedPanel1.Controls.Add(this.label2);
            this.superiorRoundedPanel1.Controls.Add(this.btnEntrarEmContato);
            this.superiorRoundedPanel1.Controls.Add(this.btnSeguir);
            this.superiorRoundedPanel1.Controls.Add(this.lblSeguidores);
            this.superiorRoundedPanel1.Controls.Add(this.lblNomeEmpresa);
            this.superiorRoundedPanel1.Location = new System.Drawing.Point(0, 402);
            this.superiorRoundedPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.superiorRoundedPanel1.Name = "superiorRoundedPanel1";
            this.superiorRoundedPanel1.Size = new System.Drawing.Size(1306, 635);
            this.superiorRoundedPanel1.TabIndex = 64;
            this.superiorRoundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.superiorRoundedPanel1_Paint);
            // 
            // lblNumSeguidores
            // 
            this.lblNumSeguidores.AutoSize = true;
            this.lblNumSeguidores.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSeguidores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblNumSeguidores.Location = new System.Drawing.Point(222, 39);
            this.lblNumSeguidores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumSeguidores.Name = "lblNumSeguidores";
            this.lblNumSeguidores.Size = new System.Drawing.Size(20, 27);
            this.lblNumSeguidores.TabIndex = 62;
            this.lblNumSeguidores.Text = "0";
            // 
            // tabControlEndereço
            // 
            this.tabControlEndereço.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlEndereço.Controls.Add(this.tabPage1);
            this.tabControlEndereço.Controls.Add(this.tabPage2);
            this.tabControlEndereço.Controls.Add(this.tabPage3);
            this.tabControlEndereço.Controls.Add(this.tabPage4);
            this.tabControlEndereço.Controls.Add(this.tabPage5);
            this.tabControlEndereço.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlEndereço.Location = new System.Drawing.Point(92, 103);
            this.tabControlEndereço.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlEndereço.Name = "tabControlEndereço";
            this.tabControlEndereço.Padding = new System.Drawing.Point(30, 15);
            this.tabControlEndereço.SelectedIndex = 0;
            this.tabControlEndereço.Size = new System.Drawing.Size(1133, 516);
            this.tabControlEndereço.TabIndex = 60;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1125, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sobre";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(16, 16);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(1030, 425);
            this.textBox2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1125, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Participações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1125, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Disponíveis";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 54);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(1125, 458);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Encerrados";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 54);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(1125, 458);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Posts";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(1124, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 27);
            this.label3.TabIndex = 59;
            this.label3.Text = "Entrar em Contato";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(1124, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 27);
            this.label2.TabIndex = 58;
            this.label2.Text = "Seguir";
            // 
            // btnEntrarEmContato
            // 
            this.btnEntrarEmContato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrarEmContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.btnEntrarEmContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntrarEmContato.BorderColor = System.Drawing.Color.Black;
            this.btnEntrarEmContato.BorderSize = 0;
            this.btnEntrarEmContato.FlatAppearance.BorderSize = 0;
            this.btnEntrarEmContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarEmContato.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrarEmContato.Image")));
            this.btnEntrarEmContato.Location = new System.Drawing.Point(1087, 55);
            this.btnEntrarEmContato.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrarEmContato.Name = "btnEntrarEmContato";
            this.btnEntrarEmContato.Size = new System.Drawing.Size(23, 26);
            this.btnEntrarEmContato.TabIndex = 57;
            this.btnEntrarEmContato.UseVisualStyleBackColor = false;
            // 
            // btnSeguir
            // 
            this.btnSeguir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeguir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.btnSeguir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeguir.BorderColor = System.Drawing.Color.Black;
            this.btnSeguir.BorderSize = 0;
            this.btnSeguir.FlatAppearance.BorderSize = 0;
            this.btnSeguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguir.Image = ((System.Drawing.Image)(resources.GetObject("btnSeguir.Image")));
            this.btnSeguir.Location = new System.Drawing.Point(1086, 22);
            this.btnSeguir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeguir.Name = "btnSeguir";
            this.btnSeguir.Size = new System.Drawing.Size(25, 28);
            this.btnSeguir.TabIndex = 56;
            this.btnSeguir.UseVisualStyleBackColor = false;
            // 
            // lblSeguidores
            // 
            this.lblSeguidores.AutoSize = true;
            this.lblSeguidores.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguidores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblSeguidores.Location = new System.Drawing.Point(230, 37);
            this.lblSeguidores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeguidores.Name = "lblSeguidores";
            this.lblSeguidores.Size = new System.Drawing.Size(96, 27);
            this.lblSeguidores.TabIndex = 20;
            this.lblSeguidores.Text = "   seguidores";
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(228, 0);
            this.lblNomeEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(83, 39);
            this.lblNomeEmpresa.TabIndex = 2;
            this.lblNomeEmpresa.Text = "Nome ";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Controls.Add(this.btnFeed);
            this.gradientPanel1.Controls.Add(this.picturePerfil);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.btnPrincipal);
            this.gradientPanel1.Controls.Add(this.btnNotificacoes);
            this.gradientPanel1.Controls.Add(this.roundedPanel5);
            this.gradientPanel1.Controls.Add(this.btnOrganizarEventos);
            this.gradientPanel1.Controls.Add(this.btnMeusEventos);
            this.gradientPanel1.Controls.Add(this.btnAjuda);
            this.gradientPanel1.Controls.Add(this.btnSobreNos);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.gradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1306, 41);
            this.gradientPanel1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.gradientPanel1.TabIndex = 4;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // btnFeed
            // 
            this.btnFeed.ActiveLinkColor = System.Drawing.Color.White;
            this.btnFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFeed.AutoSize = true;
            this.btnFeed.BackColor = System.Drawing.Color.Transparent;
            this.btnFeed.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeed.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnFeed.LinkColor = System.Drawing.Color.White;
            this.btnFeed.Location = new System.Drawing.Point(754, 12);
            this.btnFeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(35, 21);
            this.btnFeed.TabIndex = 19;
            this.btnFeed.TabStop = true;
            this.btnFeed.Text = "Feed";
            this.btnFeed.VisitedLinkColor = System.Drawing.Color.White;
            this.btnFeed.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnFeed_LinkClicked);
            // 
            // picturePerfil
            // 
            this.picturePerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePerfil.BackColor = System.Drawing.Color.Transparent;
            this.picturePerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picturePerfil.BorderColor = System.Drawing.Color.Transparent;
            this.picturePerfil.BorderColor2 = System.Drawing.Color.Transparent;
            this.picturePerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picturePerfil.BorderSize = 0;
            this.picturePerfil.GradientAngle = 50F;
            this.picturePerfil.Image = global::Acelera2025.Properties.Resources.icons8_test_account_48__1_;
            this.picturePerfil.Location = new System.Drawing.Point(1253, 2);
            this.picturePerfil.Name = "picturePerfil";
            this.picturePerfil.Size = new System.Drawing.Size(35, 35);
            this.picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePerfil.TabIndex = 18;
            this.picturePerfil.TabStop = false;
            this.picturePerfil.Click += new System.EventHandler(this.picturePerfil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrincipal.AutoSize = true;
            this.btnPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnPrincipal.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnPrincipal.LinkColor = System.Drawing.Color.White;
            this.btnPrincipal.Location = new System.Drawing.Point(50, 12);
            this.btnPrincipal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(82, 21);
            this.btnPrincipal.TabIndex = 11;
            this.btnPrincipal.TabStop = true;
            this.btnPrincipal.Text = "CONNECTA";
            this.btnPrincipal.VisitedLinkColor = System.Drawing.Color.White;
            this.btnPrincipal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnPrincipal_LinkClicked);
            // 
            // btnNotificacoes
            // 
            this.btnNotificacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotificacoes.BackColor = System.Drawing.Color.Transparent;
            this.btnNotificacoes.BackgroundImage = global::Acelera2025.Properties.Resources.IconeNotificacao;
            this.btnNotificacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNotificacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotificacoes.FlatAppearance.BorderSize = 0;
            this.btnNotificacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificacoes.Location = new System.Drawing.Point(1206, 11);
            this.btnNotificacoes.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotificacoes.Name = "btnNotificacoes";
            this.btnNotificacoes.Size = new System.Drawing.Size(22, 21);
            this.btnNotificacoes.TabIndex = 10;
            this.btnNotificacoes.UseVisualStyleBackColor = false;
            this.btnNotificacoes.Click += new System.EventHandler(this.btnNotificacoes_Click);
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel5.BorderRadius = 10;
            this.roundedPanel5.BorderSize = 0;
            this.roundedPanel5.Controls.Add(this.btnPesquisar);
            this.roundedPanel5.Controls.Add(this.txtPesquisar);
            this.roundedPanel5.Location = new System.Drawing.Point(245, 10);
            this.roundedPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(396, 25);
            this.roundedPanel5.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::Acelera2025.Properties.Resources.iconePesquisa;
            this.btnPesquisar.Location = new System.Drawing.Point(364, -2);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(32, 31);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPesquisar.Location = new System.Drawing.Point(2, 4);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(362, 26);
            this.txtPesquisar.TabIndex = 0;
            // 
            // btnOrganizarEventos
            // 
            this.btnOrganizarEventos.ActiveLinkColor = System.Drawing.Color.White;
            this.btnOrganizarEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrganizarEventos.AutoSize = true;
            this.btnOrganizarEventos.BackColor = System.Drawing.Color.Transparent;
            this.btnOrganizarEventos.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganizarEventos.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnOrganizarEventos.LinkColor = System.Drawing.Color.White;
            this.btnOrganizarEventos.Location = new System.Drawing.Point(825, 12);
            this.btnOrganizarEventos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnOrganizarEventos.Name = "btnOrganizarEventos";
            this.btnOrganizarEventos.Size = new System.Drawing.Size(105, 21);
            this.btnOrganizarEventos.TabIndex = 5;
            this.btnOrganizarEventos.TabStop = true;
            this.btnOrganizarEventos.Text = "Organizar eventos";
            this.btnOrganizarEventos.VisitedLinkColor = System.Drawing.Color.White;
            this.btnOrganizarEventos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnOrganizarEventos_LinkClicked);
            // 
            // btnMeusEventos
            // 
            this.btnMeusEventos.ActiveLinkColor = System.Drawing.Color.White;
            this.btnMeusEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMeusEventos.AutoSize = true;
            this.btnMeusEventos.BackColor = System.Drawing.Color.Transparent;
            this.btnMeusEventos.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeusEventos.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnMeusEventos.LinkColor = System.Drawing.Color.White;
            this.btnMeusEventos.Location = new System.Drawing.Point(953, 13);
            this.btnMeusEventos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnMeusEventos.Name = "btnMeusEventos";
            this.btnMeusEventos.Size = new System.Drawing.Size(83, 21);
            this.btnMeusEventos.TabIndex = 4;
            this.btnMeusEventos.TabStop = true;
            this.btnMeusEventos.Text = "Meus eventos";
            this.btnMeusEventos.VisitedLinkColor = System.Drawing.Color.White;
            this.btnMeusEventos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnMeusEventos_LinkClicked);
            // 
            // btnAjuda
            // 
            this.btnAjuda.ActiveLinkColor = System.Drawing.Color.White;
            this.btnAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjuda.AutoSize = true;
            this.btnAjuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAjuda.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnAjuda.LinkColor = System.Drawing.Color.White;
            this.btnAjuda.Location = new System.Drawing.Point(1054, 12);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(41, 21);
            this.btnAjuda.TabIndex = 3;
            this.btnAjuda.TabStop = true;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.VisitedLinkColor = System.Drawing.Color.White;
            this.btnAjuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAjuda_LinkClicked);
            // 
            // btnSobreNos
            // 
            this.btnSobreNos.ActiveLinkColor = System.Drawing.Color.White;
            this.btnSobreNos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSobreNos.AutoSize = true;
            this.btnSobreNos.BackColor = System.Drawing.Color.Transparent;
            this.btnSobreNos.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobreNos.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnSobreNos.LinkColor = System.Drawing.Color.White;
            this.btnSobreNos.Location = new System.Drawing.Point(1109, 13);
            this.btnSobreNos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnSobreNos.Name = "btnSobreNos";
            this.btnSobreNos.Size = new System.Drawing.Size(62, 21);
            this.btnSobreNos.TabIndex = 2;
            this.btnSobreNos.TabStop = true;
            this.btnSobreNos.Text = "Sobre nós";
            this.btnSobreNos.VisitedLinkColor = System.Drawing.Color.White;
            this.btnSobreNos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSobreNos_LinkClicked);
            // 
            // lblEnderecoCompleto
            // 
            this.lblEnderecoCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnderecoCompleto.AutoSize = true;
            this.lblEnderecoCompleto.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblEnderecoCompleto.Location = new System.Drawing.Point(320, 362);
            this.lblEnderecoCompleto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnderecoCompleto.Name = "lblEnderecoCompleto";
            this.lblEnderecoCompleto.Size = new System.Drawing.Size(18, 27);
            this.lblEnderecoCompleto.TabIndex = 63;
            this.lblEnderecoCompleto.Text = "-";
            // 
            // PerfilEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1306, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PerfilEmpresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PerfilEmpresa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfilEmpresa)).EndInit();
            this.panelMeusEventos.ResumeLayout(false);
            this.superiorRoundedPanel1.ResumeLayout(false);
            this.superiorRoundedPanel1.PerformLayout();
            this.tabControlEndereço.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button btnNotificacoes;
        private RoundedPanel roundedPanel5;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.LinkLabel btnOrganizarEventos;
        private System.Windows.Forms.LinkLabel btnMeusEventos;
        private System.Windows.Forms.LinkLabel btnAjuda;
        private System.Windows.Forms.LinkLabel btnSobreNos;
        private System.Windows.Forms.Panel panel1;
        private RoundedPanel panelMeusEventos;
        private RoundedButton btnEventosCriados;
        private RoundedButton btnEventosIngressados;
        private SuperiorRoundedPanel superiorRoundedPanel1;
        private System.Windows.Forms.TabControl tabControlEndereço;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CircularButton btnEntrarEmContato;
        private CircularButton btnSeguir;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel btnPrincipal;
        private CircularButton btnLapis;
        private Tools.CircularPictureBox picPerfilEmpresa;
        private Tools.CircularPictureBox picturePerfil;
        private System.Windows.Forms.LinkLabel btnFeed;
        private System.Windows.Forms.Label lblSeguidores;
        private System.Windows.Forms.Label lblNumSeguidores;
        private System.Windows.Forms.Label lblEnderecoCompleto;
    }
}