namespace Acelera2025.Telas
{
    partial class EventoCard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCidadeEstado = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.PicEvento = new SuperiorRoundedPic();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCidadeEstado);
            this.panel2.Controls.Add(this.lblRua);
            this.panel2.Controls.Add(this.lblLocal);
            this.panel2.Controls.Add(this.lblDataHora);
            this.panel2.Controls.Add(this.lblNomeEvento);
            this.panel2.Controls.Add(this.PicEvento);
            this.panel2.Location = new System.Drawing.Point(-6, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1267, 182);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblCidadeEstado
            // 
            this.lblCidadeEstado.AutoSize = true;
            this.lblCidadeEstado.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblCidadeEstado.Location = new System.Drawing.Point(492, 138);
            this.lblCidadeEstado.Name = "lblCidadeEstado";
            this.lblCidadeEstado.Size = new System.Drawing.Size(99, 32);
            this.lblCidadeEstado.TabIndex = 6;
            this.lblCidadeEstado.Text = "Cidade, UF";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblRua.Location = new System.Drawing.Point(492, 106);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(200, 32);
            this.lblRua.TabIndex = 5;
            this.lblRua.Text = "Nome da rua, n°, bairro";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblLocal.Location = new System.Drawing.Point(492, 74);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(54, 32);
            this.lblLocal.TabIndex = 4;
            this.lblLocal.Text = "Local";
            this.lblLocal.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblDataHora.Location = new System.Drawing.Point(492, 42);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(102, 32);
            this.lblDataHora.TabIndex = 3;
            this.lblDataHora.Text = "data - hora";
            this.lblDataHora.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.lblNomeEvento.Location = new System.Drawing.Point(489, 4);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(229, 50);
            this.lblNomeEvento.TabIndex = 2;
            this.lblNomeEvento.Text = "Nome do Evento";
            // 
            // PicEvento
            // 
            this.PicEvento.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PicEvento.BorderColor = System.Drawing.Color.Black;
            this.PicEvento.BorderRadius = 20;
            this.PicEvento.BorderSize = 0;
            this.PicEvento.Location = new System.Drawing.Point(15, 15);
            this.PicEvento.Name = "PicEvento";
            this.PicEvento.Size = new System.Drawing.Size(437, 151);
            this.PicEvento.TabIndex = 0;
            this.PicEvento.TabStop = false;
            // 
            // EventoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "EventoCard";
            this.Size = new System.Drawing.Size(1261, 182);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicEvento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private SuperiorRoundedPic PicEvento;
        private System.Windows.Forms.Label lblNomeEvento;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblCidadeEstado;
        private System.Windows.Forms.Label lblRua;
    }
}
