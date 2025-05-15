namespace Acelera2025.Telas
{
    partial class CardParticipantes
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
            this.picPerfil = new CircularPanel();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // picPerfil
            // 
            this.picPerfil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picPerfil.BorderColor = System.Drawing.Color.Black;
            this.picPerfil.BorderSize = 0;
            this.picPerfil.Location = new System.Drawing.Point(14, 17);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(43, 42);
            this.picPerfil.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNome.Location = new System.Drawing.Point(87, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 30);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // CardParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.picPerfil);
            this.Name = "CardParticipantes";
            this.Size = new System.Drawing.Size(377, 77);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPanel picPerfil;
        private System.Windows.Forms.Label lblNome;
    }
}
