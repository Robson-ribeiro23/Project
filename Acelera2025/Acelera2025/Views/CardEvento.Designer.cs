namespace Acelera2025.Telas
{
    partial class CardEvento
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
            this.lblDataHora = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.lblCidadeEstado = new System.Windows.Forms.Label();
            this.PicEvento = new SuperiorRoundedPic();
            ((System.ComponentModel.ISupportInitialize)(this.PicEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblDataHora.Location = new System.Drawing.Point(491, 49);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(107, 32);
            this.lblDataHora.TabIndex = 12;
            this.lblDataHora.Text = "Data - Hora";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblRua.Location = new System.Drawing.Point(491, 113);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(200, 32);
            this.lblRua.TabIndex = 11;
            this.lblRua.Text = "Nome da rua, n°, bairro";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblLocal.Location = new System.Drawing.Point(491, 81);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(54, 32);
            this.lblLocal.TabIndex = 10;
            this.lblLocal.Text = "Local";
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.lblNomeEvento.Location = new System.Drawing.Point(488, 11);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(229, 50);
            this.lblNomeEvento.TabIndex = 9;
            this.lblNomeEvento.Text = "Nome do Evento";
            // 
            // lblCidadeEstado
            // 
            this.lblCidadeEstado.AutoSize = true;
            this.lblCidadeEstado.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblCidadeEstado.Location = new System.Drawing.Point(491, 141);
            this.lblCidadeEstado.Name = "lblCidadeEstado";
            this.lblCidadeEstado.Size = new System.Drawing.Size(99, 32);
            this.lblCidadeEstado.TabIndex = 13;
            this.lblCidadeEstado.Text = "Cidade, UF";
            // 
            // PicEvento
            // 
            this.PicEvento.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PicEvento.BorderColor = System.Drawing.Color.Black;
            this.PicEvento.BorderRadius = 20;
            this.PicEvento.BorderSize = 0;
            this.PicEvento.Location = new System.Drawing.Point(14, 22);
            this.PicEvento.Name = "PicEvento";
            this.PicEvento.Size = new System.Drawing.Size(437, 151);
            this.PicEvento.TabIndex = 8;
            this.PicEvento.TabStop = false;
            // 
            // CardEvento
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblCidadeEstado);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblNomeEvento);
            this.Controls.Add(this.PicEvento);
            this.Name = "CardEvento";
            this.Size = new System.Drawing.Size(1190, 176);
            ((System.ComponentModel.ISupportInitialize)(this.PicEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblNomeEvento;
        private System.Windows.Forms.Label lblCidadeEstado;
        private SuperiorRoundedPic PicEvento;
    }
}
