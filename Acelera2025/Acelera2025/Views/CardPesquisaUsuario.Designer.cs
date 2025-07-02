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
            this.lblNome = new System.Windows.Forms.Label();
            this.picPerfil = new Acelera2025.Views.Tools.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNome.Location = new System.Drawing.Point(84, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(69, 36);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click_1);
            // 
            // picPerfil
            // 
            this.picPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picPerfil.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picPerfil.BorderColor2 = System.Drawing.Color.HotPink;
            this.picPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picPerfil.BorderSize = 2;
            this.picPerfil.GradientAngle = 50F;
            this.picPerfil.Image = global::Acelera2025.Properties.Resources.icons8_test_account_48__1_;
            this.picPerfil.Location = new System.Drawing.Point(17, 3);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(52, 52);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerfil.TabIndex = 3;
            this.picPerfil.TabStop = false;
            // 
            // CardPesquisaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picPerfil);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CardPesquisaUsuario";
            this.Size = new System.Drawing.Size(860, 58);
            this.Load += new System.EventHandler(this.CardPesquisaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private Views.Tools.CircularPictureBox picPerfil;
    }
}
