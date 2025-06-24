namespace Acelera2025.Telas
{
    partial class CardCriarPostVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardCriarPostVideo));
            this.roundedPanel1 = new RoundedPanel();
            this.video = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPostar = new RoundedButton();
            this.btnSelecionarVideo = new System.Windows.Forms.Button();
            this.picPerfil = new CircularPanel();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 2;
            this.roundedPanel1.Controls.Add(this.video);
            this.roundedPanel1.Controls.Add(this.panel1);
            this.roundedPanel1.Controls.Add(this.btnSelecionarVideo);
            this.roundedPanel1.Controls.Add(this.picPerfil);
            this.roundedPanel1.Controls.Add(this.txtTexto);
            this.roundedPanel1.Controls.Add(this.btnFechar);
            this.roundedPanel1.Controls.Add(this.pictureBox1);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(858, 375);
            this.roundedPanel1.TabIndex = 1;
            // 
            // video
            // 
            this.video.Enabled = true;
            this.video.Location = new System.Drawing.Point(582, 78);
            this.video.Name = "video";
            this.video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video.OcxState")));
            this.video.Size = new System.Drawing.Size(250, 198);
            this.video.TabIndex = 48;
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
            this.btnPostar.Click += new System.EventHandler(this.btnPostar_Click);
            // 
            // btnSelecionarVideo
            // 
            this.btnSelecionarVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarVideo.BackColor = System.Drawing.Color.Transparent;
            this.btnSelecionarVideo.BackgroundImage = global::Acelera2025.Properties.Resources.icons8_create_100;
            this.btnSelecionarVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelecionarVideo.FlatAppearance.BorderSize = 0;
            this.btnSelecionarVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarVideo.Location = new System.Drawing.Point(553, 160);
            this.btnSelecionarVideo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarVideo.Name = "btnSelecionarVideo";
            this.btnSelecionarVideo.Size = new System.Drawing.Size(22, 27);
            this.btnSelecionarVideo.TabIndex = 47;
            this.btnSelecionarVideo.UseVisualStyleBackColor = false;
            this.btnSelecionarVideo.Click += new System.EventHandler(this.btnSelecionarVideo_Click);
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
            this.picPerfil.Location = new System.Drawing.Point(17, 66);
            this.picPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(74, 76);
            this.picPerfil.TabIndex = 41;
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(107, 78);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(419, 198);
            this.txtTexto.TabIndex = 42;
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
            this.btnFechar.Location = new System.Drawing.Point(801, 20);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(28, 36);
            this.btnFechar.TabIndex = 43;
            this.btnFechar.TabStop = true;
            this.btnFechar.Text = "X";
            this.btnFechar.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // CardCriarPostVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel1);
            this.Name = "CardCriarPostVideo";
            this.Size = new System.Drawing.Size(858, 375);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Panel panel1;
        private RoundedButton btnPostar;
        private System.Windows.Forms.Button btnSelecionarVideo;
        private CircularPanel picPerfil;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.LinkLabel btnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer video;
    }
}
