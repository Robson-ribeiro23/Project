namespace Acelera2025.Views
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
            this.lblNome = new System.Windows.Forms.Label();
            this.picturePerfil = new Acelera2025.Views.Tools.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNome.Location = new System.Drawing.Point(65, 24);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 25);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // picturePerfil
            // 
            this.picturePerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePerfil.BackColor = System.Drawing.Color.Transparent;
            this.picturePerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picturePerfil.BorderColor = System.Drawing.Color.Transparent;
            this.picturePerfil.BorderColor2 = System.Drawing.Color.Transparent;
            this.picturePerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picturePerfil.BorderSize = 1;
            this.picturePerfil.GradientAngle = 50F;
            this.picturePerfil.Image = global::Acelera2025.Properties.Resources.icons8_test_account_48__1_;
            this.picturePerfil.Location = new System.Drawing.Point(14, 14);
            this.picturePerfil.Name = "picturePerfil";
            this.picturePerfil.Size = new System.Drawing.Size(35, 35);
            this.picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePerfil.TabIndex = 18;
            this.picturePerfil.TabStop = false;
            // 
            // CardParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picturePerfil);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CardParticipantes";
            this.Size = new System.Drawing.Size(283, 63);
            this.Load += new System.EventHandler(this.CardParticipantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblNome;
        private Tools.CircularPictureBox picturePerfil;
    }
}
