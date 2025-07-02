namespace Acelera2025.Telas
{
    partial class CardNotificacao
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundedPanel1 = new RoundedPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVerNotificacao = new System.Windows.Forms.LinkLabel();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picPerfil = new CircularPanel();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.panel1);
            this.roundedPanel1.Controls.Add(this.btnVerNotificacao);
            this.roundedPanel1.Controls.Add(this.lblDescricao);
            this.roundedPanel1.Controls.Add(this.lblTitulo);
            this.roundedPanel1.Controls.Add(this.picPerfil);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(236, 81);
            this.roundedPanel1.TabIndex = 0;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(2, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 3);
            this.panel1.TabIndex = 70;
            // 
            // btnVerNotificacao
            // 
            this.btnVerNotificacao.AutoSize = true;
            this.btnVerNotificacao.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.btnVerNotificacao.Location = new System.Drawing.Point(203, 60);
            this.btnVerNotificacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnVerNotificacao.Name = "btnVerNotificacao";
            this.btnVerNotificacao.Size = new System.Drawing.Size(23, 13);
            this.btnVerNotificacao.TabIndex = 69;
            this.btnVerNotificacao.TabStop = true;
            this.btnVerNotificacao.Text = "Ver";
            this.btnVerNotificacao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnVerNotificacao_LinkClicked);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblDescricao.Location = new System.Drawing.Point(32, 40);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(0, 21);
            this.lblDescricao.TabIndex = 68;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblTitulo.Location = new System.Drawing.Point(44, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(46, 25);
            this.lblTitulo.TabIndex = 67;
            this.lblTitulo.Text = "Titulo";
            // 
            // picPerfil
            // 
            this.picPerfil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picPerfil.BorderColor = System.Drawing.Color.Black;
            this.picPerfil.BorderSize = 0;
            this.picPerfil.Location = new System.Drawing.Point(9, 11);
            this.picPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(31, 27);
            this.picPerfil.TabIndex = 66;
            // 
            // CardNotificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CardNotificacao";
            this.Size = new System.Drawing.Size(236, 81);
            this.Load += new System.EventHandler(this.CardNotificacao_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public RoundedPanel roundedPanel1;
        public System.Windows.Forms.Label lblDescricao;
        public System.Windows.Forms.Label lblTitulo;
        public CircularPanel picPerfil;
        public System.Windows.Forms.LinkLabel btnVerNotificacao;
        public System.Windows.Forms.Panel panel1;
    }
}
