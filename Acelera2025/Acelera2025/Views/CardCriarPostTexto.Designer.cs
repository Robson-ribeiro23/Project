namespace Acelera2025.Telas
{
    partial class CardCriarPostTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardCriarPostTexto));
            this.roundedPanel1 = new RoundedPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPostar = new RoundedButton();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.picPerfil = new CircularPanel();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 2;
            this.roundedPanel1.Controls.Add(this.pictureBox1);
            this.roundedPanel1.Controls.Add(this.btnFechar);
            this.roundedPanel1.Controls.Add(this.panel1);
            this.roundedPanel1.Controls.Add(this.txtTexto);
            this.roundedPanel1.Controls.Add(this.picPerfil);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(858, 375);
            this.roundedPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.ActiveLinkColor = System.Drawing.Color.White;
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.AutoSize = true;
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnFechar.LinkColor = System.Drawing.Color.Black;
            this.btnFechar.Location = new System.Drawing.Point(804, 23);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(28, 36);
            this.btnFechar.TabIndex = 35;
            this.btnFechar.TabStop = true;
            this.btnFechar.Text = "X";
            this.btnFechar.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPostar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 73);
            this.panel1.TabIndex = 12;
            // 
            // btnPostar
            // 
            this.btnPostar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPostar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.btnPostar.BorderColor = System.Drawing.Color.Black;
            this.btnPostar.BorderRadius = 10;
            this.btnPostar.BorderSize = 0;
            this.btnPostar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPostar.Location = new System.Drawing.Point(667, 17);
            this.btnPostar.Name = "btnPostar";
            this.btnPostar.Size = new System.Drawing.Size(165, 36);
            this.btnPostar.TabIndex = 12;
            this.btnPostar.Text = "Postar";
            this.btnPostar.UseVisualStyleBackColor = false;
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(135, 92);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(632, 163);
            this.txtTexto.TabIndex = 11;
            // 
            // picPerfil
            // 
            this.picPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picPerfil.BackColor = System.Drawing.Color.Transparent;
            this.picPerfil.BackgroundImage = global::Acelera2025.Properties.Resources.icons8_test_account_48__1_;
            this.picPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPerfil.BorderColor = System.Drawing.Color.Black;
            this.picPerfil.BorderSize = 0;
            this.picPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPerfil.Location = new System.Drawing.Point(47, 81);
            this.picPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(74, 76);
            this.picPerfil.TabIndex = 10;
            // 
            // CardCriarPostTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel1);
            this.Name = "CardCriarPostTexto";
            this.Size = new System.Drawing.Size(858, 375);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.TextBox txtTexto;
        private CircularPanel picPerfil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel btnFechar;
        private RoundedButton btnPostar;
    }
}
