namespace Acelera2025.Telas
{
    partial class CardPesquisaUsuario
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
            this.picPerfil = new Acelera2025.Ferramentas.RoundedPicture();
            this.lblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // picPerfil
            // 
            this.picPerfil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picPerfil.BorderColor = System.Drawing.Color.Black;
            this.picPerfil.BorderRadius = 15;
            this.picPerfil.BorderSize = 0;
            this.picPerfil.Location = new System.Drawing.Point(14, 10);
            this.picPerfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(28, 30);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerfil.TabIndex = 0;
            this.picPerfil.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNome.Location = new System.Drawing.Point(56, 15);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 25);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // CardPesquisaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.picPerfil);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CardPesquisaUsuario";
            this.Size = new System.Drawing.Size(645, 47);
            this.Load += new System.EventHandler(this.CardPesquisaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ferramentas.RoundedPicture picPerfil;
        private System.Windows.Forms.Label lblNome;
    }
}
