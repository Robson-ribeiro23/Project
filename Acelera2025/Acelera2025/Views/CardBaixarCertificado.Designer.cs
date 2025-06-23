namespace Acelera2025.Telas
{
    partial class CardBaixarCertificado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBaixarCertificado = new RoundedButton();
            this.SuspendLayout();
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.lblNomeEvento.Location = new System.Drawing.Point(23, 16);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(163, 36);
            this.lblNomeEvento.TabIndex = 10;
            this.lblNomeEvento.Text = "Nome do Evento";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.panel1.Location = new System.Drawing.Point(57, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 1);
            this.panel1.TabIndex = 17;
            // 
            // btnBaixarCertificado
            // 
            this.btnBaixarCertificado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBaixarCertificado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.btnBaixarCertificado.BorderColor = System.Drawing.Color.Black;
            this.btnBaixarCertificado.BorderRadius = 10;
            this.btnBaixarCertificado.BorderSize = 0;
            this.btnBaixarCertificado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaixarCertificado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixarCertificado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBaixarCertificado.Location = new System.Drawing.Point(727, 12);
            this.btnBaixarCertificado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBaixarCertificado.Name = "btnBaixarCertificado";
            this.btnBaixarCertificado.Size = new System.Drawing.Size(166, 39);
            this.btnBaixarCertificado.TabIndex = 16;
            this.btnBaixarCertificado.Text = "Baixar Certificado";
            this.btnBaixarCertificado.UseVisualStyleBackColor = true;
            this.btnBaixarCertificado.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // CardBaixarCertificado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBaixarCertificado);
            this.Controls.Add(this.lblNomeEvento);
            this.Name = "CardBaixarCertificado";
            this.Size = new System.Drawing.Size(1115, 60);
            this.Load += new System.EventHandler(this.CardBaixarCertificado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeEvento;
        private RoundedButton btnBaixarCertificado;
        private System.Windows.Forms.Panel panel1;
    }
}
