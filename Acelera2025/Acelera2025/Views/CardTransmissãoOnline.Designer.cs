namespace Acelera2025.Telas
{
    partial class CardTransmissãoOnline
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
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopiarLink = new RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.lblNomeEvento.Location = new System.Drawing.Point(13, 12);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(163, 36);
            this.lblNomeEvento.TabIndex = 11;
            this.lblNomeEvento.Text = "Nome do Evento";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblDataHora.Location = new System.Drawing.Point(510, 16);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(107, 32);
            this.lblDataHora.TabIndex = 21;
            this.lblDataHora.Text = "Data - Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(606, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 22;
            // 
            // btnCopiarLink
            // 
            this.btnCopiarLink.BackColor = System.Drawing.Color.Transparent;
            this.btnCopiarLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCopiarLink.BorderColor = System.Drawing.Color.White;
            this.btnCopiarLink.BorderRadius = 20;
            this.btnCopiarLink.BorderSize = 3;
            this.btnCopiarLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopiarLink.Image = global::Acelera2025.Properties.Resources.icons8_copy_24;
            this.btnCopiarLink.Location = new System.Drawing.Point(863, 12);
            this.btnCopiarLink.Name = "btnCopiarLink";
            this.btnCopiarLink.Size = new System.Drawing.Size(40, 36);
            this.btnCopiarLink.TabIndex = 23;
            this.btnCopiarLink.UseVisualStyleBackColor = false;
            this.btnCopiarLink.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(909, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Copiar Link";
            // 
            // CardTransmissãoOnline
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCopiarLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.lblNomeEvento);
            this.Name = "CardTransmissãoOnline";
            this.Size = new System.Drawing.Size(1115, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeEvento;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label label1;
        private RoundedButton btnCopiarLink;
        private System.Windows.Forms.Label label2;
    }
}
