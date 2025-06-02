namespace Acelera2025.Telas
{
    partial class Pesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa));
            this.gradientPanel1 = new GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrincipal = new System.Windows.Forms.LinkLabel();
            this.btnNotificacoes = new System.Windows.Forms.Button();
            this.btnPerfil = new CircularPanel();
            this.btnOrganizarEventos = new System.Windows.Forms.LinkLabel();
            this.btnMeusEventos = new System.Windows.Forms.LinkLabel();
            this.btnAjuda = new System.Windows.Forms.LinkLabel();
            this.btnSobreNos = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientPanel2 = new GradientPanel();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.comboUF = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.roundedPanel1 = new RoundedPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboFiltrarBusca = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.btnPrincipal);
            this.gradientPanel1.Controls.Add(this.btnNotificacoes);
            this.gradientPanel1.Controls.Add(this.btnPerfil);
            this.gradientPanel1.Controls.Add(this.btnOrganizarEventos);
            this.gradientPanel1.Controls.Add(this.btnMeusEventos);
            this.gradientPanel1.Controls.Add(this.btnAjuda);
            this.gradientPanel1.Controls.Add(this.btnSobreNos);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.gradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1094, 41);
            this.gradientPanel1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.gradientPanel1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnNotificacoes.Location = new System.Drawing.Point(994, 11);
            this.btnNotificacoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNotificacoes.Name = "btnNotificacoes";
            this.btnNotificacoes.Size = new System.Drawing.Size(22, 21);
            this.btnNotificacoes.TabIndex = 10;
            this.btnNotificacoes.UseVisualStyleBackColor = false;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.BackgroundImage = global::Acelera2025.Properties.Resources.usuario;
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPerfil.BorderColor = System.Drawing.Color.Black;
            this.btnPerfil.BorderSize = 2;
            this.btnPerfil.Location = new System.Drawing.Point(1041, 2);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(35, 39);
            this.btnPerfil.TabIndex = 9;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
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
            this.btnOrganizarEventos.Location = new System.Drawing.Point(613, 12);
            this.btnOrganizarEventos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnOrganizarEventos.Name = "btnOrganizarEventos";
            this.btnOrganizarEventos.Size = new System.Drawing.Size(105, 21);
            this.btnOrganizarEventos.TabIndex = 5;
            this.btnOrganizarEventos.TabStop = true;
            this.btnOrganizarEventos.Text = "Organizar eventos";
            this.btnOrganizarEventos.VisitedLinkColor = System.Drawing.Color.White;
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
            this.btnMeusEventos.Location = new System.Drawing.Point(742, 12);
            this.btnMeusEventos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnMeusEventos.Name = "btnMeusEventos";
            this.btnMeusEventos.Size = new System.Drawing.Size(83, 21);
            this.btnMeusEventos.TabIndex = 4;
            this.btnMeusEventos.TabStop = true;
            this.btnMeusEventos.Text = "Meus eventos";
            this.btnMeusEventos.VisitedLinkColor = System.Drawing.Color.White;
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
            this.btnAjuda.Location = new System.Drawing.Point(842, 12);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(41, 21);
            this.btnAjuda.TabIndex = 3;
            this.btnAjuda.TabStop = true;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.VisitedLinkColor = System.Drawing.Color.White;
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
            this.btnSobreNos.Location = new System.Drawing.Point(897, 13);
            this.btnSobreNos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnSobreNos.Name = "btnSobreNos";
            this.btnSobreNos.Size = new System.Drawing.Size(62, 21);
            this.btnSobreNos.TabIndex = 2;
            this.btnSobreNos.TabStop = true;
            this.btnSobreNos.Text = "Sobre nós";
            this.btnSobreNos.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.gradientPanel2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 502);
            this.panel1.TabIndex = 26;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel2.Controls.Add(this.comboCategoria);
            this.gradientPanel2.Controls.Add(this.comboUF);
            this.gradientPanel2.Controls.Add(this.label10);
            this.gradientPanel2.Controls.Add(this.comboBox2);
            this.gradientPanel2.Controls.Add(this.roundedPanel1);
            this.gradientPanel2.Controls.Add(this.comboFiltrarBusca);
            this.gradientPanel2.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.gradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientPanel2.Location = new System.Drawing.Point(0, -5);
            this.gradientPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(1094, 178);
            this.gradientPanel2.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.gradientPanel2.TabIndex = 13;
            // 
            // comboCategoria
            // 
            this.comboCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboCategoria.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(259, 130);
            this.comboCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(186, 29);
            this.comboCategoria.TabIndex = 13;
            this.comboCategoria.Text = "Categoria";
            // 
            // comboUF
            // 
            this.comboUF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboUF.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUF.FormattingEnabled = true;
            this.comboUF.Location = new System.Drawing.Point(901, 130);
            this.comboUF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(44, 29);
            this.comboUF.TabIndex = 12;
            this.comboUF.Text = "UF";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(137, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 43);
            this.label10.TabIndex = 11;
            this.label10.Text = "Pesquisar";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(806, 130);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 29);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.Text = "Cidade";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 10;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.button1);
            this.roundedPanel1.Controls.Add(this.textBox1);
            this.roundedPanel1.Location = new System.Drawing.Point(144, 84);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(800, 29);
            this.roundedPanel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Acelera2025.Properties.Resources.iconePesquisa;
            this.button1.Location = new System.Drawing.Point(768, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 29);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.Location = new System.Drawing.Point(9, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(761, 27);
            this.textBox1.TabIndex = 0;
            // 
            // comboFiltrarBusca
            // 
            this.comboFiltrarBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboFiltrarBusca.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFiltrarBusca.FormattingEnabled = true;
            this.comboFiltrarBusca.Location = new System.Drawing.Point(144, 130);
            this.comboFiltrarBusca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboFiltrarBusca.Name = "comboFiltrarBusca";
            this.comboFiltrarBusca.Size = new System.Drawing.Size(92, 29);
            this.comboFiltrarBusca.TabIndex = 10;
            this.comboFiltrarBusca.Text = "Evento";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(144, 196);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 296);
            this.panel2.TabIndex = 12;
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pesquisa";
            this.Text = "Pesquisa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pesquisa_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel btnPrincipal;
        private System.Windows.Forms.Button btnNotificacoes;
        private CircularPanel btnPerfil;
        private System.Windows.Forms.LinkLabel btnOrganizarEventos;
        private System.Windows.Forms.LinkLabel btnMeusEventos;
        private System.Windows.Forms.LinkLabel btnAjuda;
        private System.Windows.Forms.LinkLabel btnSobreNos;
        private System.Windows.Forms.Panel panel1;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboUF;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboFiltrarBusca;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.ComboBox comboCategoria;
    }
}