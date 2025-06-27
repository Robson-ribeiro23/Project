namespace Acelera2025.Views
{
    partial class CardPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardPerfil));
            this.roundedPanel2 = new RoundedPanel();
            this.picturePerfil = new Acelera2025.Views.Tools.CircularPictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.btnPerfil = new System.Windows.Forms.LinkLabel();
            this.btnSair = new System.Windows.Forms.LinkLabel();
            this.lblNome = new System.Windows.Forms.Label();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundedPanel2.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.BorderSize = 0;
            this.roundedPanel2.Controls.Add(this.picturePerfil);
            this.roundedPanel2.Controls.Add(this.pictureBox2);
            this.roundedPanel2.Controls.Add(this.linkLabel3);
            this.roundedPanel2.Controls.Add(this.btnPerfil);
            this.roundedPanel2.Controls.Add(this.btnSair);
            this.roundedPanel2.Controls.Add(this.lblNome);
            this.roundedPanel2.Location = new System.Drawing.Point(0, 1);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(284, 126);
            this.roundedPanel2.TabIndex = 15;
            this.roundedPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel2_Paint);
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
            this.picturePerfil.Location = new System.Drawing.Point(13, 44);
            this.picturePerfil.Name = "picturePerfil";
            this.picturePerfil.Size = new System.Drawing.Size(35, 35);
            this.picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePerfil.TabIndex = 17;
            this.picturePerfil.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.IndianRed;
            this.linkLabel3.Location = new System.Drawing.Point(58, 15);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(72, 18);
            this.linkLabel3.TabIndex = 15;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "CONNECTA";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // btnPerfil
            // 
            this.btnPerfil.ActiveLinkColor = System.Drawing.Color.White;
            this.btnPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerfil.AutoSize = true;
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.btnPerfil.LinkColor = System.Drawing.Color.Black;
            this.btnPerfil.Location = new System.Drawing.Point(50, 84);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(55, 20);
            this.btnPerfil.TabIndex = 14;
            this.btnPerfil.TabStop = true;
            this.btnPerfil.Text = "Ver Perfil";
            this.btnPerfil.VisitedLinkColor = System.Drawing.Color.White;
            this.btnPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnPerfil_LinkClicked);
            // 
            // btnSair
            // 
            this.btnSair.ActiveLinkColor = System.Drawing.Color.White;
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.AutoSize = true;
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.btnSair.LinkColor = System.Drawing.Color.Firebrick;
            this.btnSair.Location = new System.Drawing.Point(236, 15);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 20);
            this.btnSair.TabIndex = 13;
            this.btnSair.TabStop = true;
            this.btnSair.Text = "Sair";
            this.btnSair.VisitedLinkColor = System.Drawing.Color.White;
            this.btnSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSair_LinkClicked);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblNome.Location = new System.Drawing.Point(50, 54);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 21);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome";
            // 
            // CardPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CardPerfil";
            this.Size = new System.Drawing.Size(284, 128);
            this.Load += new System.EventHandler(this.CardPerfil_Load);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel btnPerfil;
        private System.Windows.Forms.LinkLabel btnSair;
        private System.Windows.Forms.Label lblNome;
        private Tools.CircularPictureBox picturePerfil;
    }
}
