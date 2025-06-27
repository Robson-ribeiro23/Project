namespace Acelera2025.Views
{ 
    partial class CardEventoTelaInicial
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label14 = new System.Windows.Forms.Label();
            this.lblCidadeUf = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnNome = new System.Windows.Forms.LinkLabel();
            this.PicEvento = new SuperiorRoundedPic();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundedPanel1.AutoSize = true;
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.label14);
            this.roundedPanel1.Controls.Add(this.lblCidadeUf);
            this.roundedPanel1.Controls.Add(this.lblHora);
            this.roundedPanel1.Controls.Add(this.lblData);
            this.roundedPanel1.Controls.Add(this.btnNome);
            this.roundedPanel1.Controls.Add(this.PicEvento);
            this.roundedPanel1.Location = new System.Drawing.Point(6, 10);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(347, 248);
            this.roundedPanel1.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.label14.Location = new System.Drawing.Point(105, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 53);
            this.label14.TabIndex = 21;
            this.label14.Text = "-";
            // 
            // lblCidadeUf
            // 
            this.lblCidadeUf.AutoSize = true;
            this.lblCidadeUf.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeUf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblCidadeUf.Location = new System.Drawing.Point(13, 216);
            this.lblCidadeUf.Name = "lblCidadeUf";
            this.lblCidadeUf.Size = new System.Drawing.Size(91, 30);
            this.lblCidadeUf.TabIndex = 20;
            this.lblCidadeUf.Text = "Cidade UF";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblHora.Location = new System.Drawing.Point(146, 186);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(63, 36);
            this.lblHora.TabIndex = 19;
            this.lblHora.Text = "00:00";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblData.Location = new System.Drawing.Point(12, 186);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(97, 36);
            this.lblData.TabIndex = 18;
            this.lblData.Text = "00/00/00";
            // 
            // btnNome
            // 
            this.btnNome.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.btnNome.AutoSize = true;
            this.btnNome.BackColor = System.Drawing.Color.Transparent;
            this.btnNome.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNome.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnNome.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.btnNome.Location = new System.Drawing.Point(11, 146);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(83, 41);
            this.btnNome.TabIndex = 17;
            this.btnNome.TabStop = true;
            this.btnNome.Text = "Nome";
            this.btnNome.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // PicEvento
            // 
            this.PicEvento.BorderColor = System.Drawing.Color.Black;
            this.PicEvento.BorderRadius = 20;
            this.PicEvento.BorderSize = 0;
            this.PicEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicEvento.Dock = System.Windows.Forms.DockStyle.Top;
            this.PicEvento.Location = new System.Drawing.Point(0, 0);
            this.PicEvento.Name = "PicEvento";
            this.PicEvento.Size = new System.Drawing.Size(347, 143);
            this.PicEvento.TabIndex = 4;
            this.PicEvento.TabStop = false;
            // 
            // CardEventoTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel1);
            this.Name = "CardEventoTelaInicial";
            this.Size = new System.Drawing.Size(359, 267);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCidadeUf;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.LinkLabel btnNome;
        private SuperiorRoundedPic PicEvento;
    }
}
