namespace Acelera2025.Telas
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.btnPerfil = new System.Windows.Forms.LinkLabel();
            this.btnSair = new System.Windows.Forms.LinkLabel();
            this.lblNome = new System.Windows.Forms.Label();
            this.picPerfil = new CircularPanel();
            this.roundedPanel2.SuspendLayout();
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
            this.roundedPanel2.Controls.Add(this.pictureBox2);
            this.roundedPanel2.Controls.Add(this.linkLabel3);
            this.roundedPanel2.Controls.Add(this.btnPerfil);
            this.roundedPanel2.Controls.Add(this.btnSair);
            this.roundedPanel2.Controls.Add(this.lblNome);
            this.roundedPanel2.Controls.Add(this.picPerfil);
            this.roundedPanel2.Location = new System.Drawing.Point(0, 1);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(379, 155);
            this.roundedPanel2.TabIndex = 15;
            this.roundedPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 28);
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
            this.linkLabel3.Location = new System.Drawing.Point(77, 18);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(90, 22);
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
            this.btnPerfil.Location = new System.Drawing.Point(67, 103);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(63, 23);
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
            this.btnSair.Location = new System.Drawing.Point(315, 18);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(32, 23);
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
            this.lblNome.Location = new System.Drawing.Point(67, 66);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 27);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome";
            // 
            // picPerfil
            // 
            this.picPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picPerfil.BackColor = System.Drawing.Color.Transparent;
            this.picPerfil.BackgroundImage = global::Acelera2025.Properties.Resources.usuario;
            this.picPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPerfil.BorderColor = System.Drawing.Color.Black;
            this.picPerfil.BorderSize = 0;
            this.picPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPerfil.Location = new System.Drawing.Point(17, 54);
            this.picPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(42, 44);
            this.picPerfil.TabIndex = 10;
            this.picPerfil.Paint += new System.Windows.Forms.PaintEventHandler(this.picPerfil_Paint);
            // 
            // CardPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CardPerfil";
            this.Size = new System.Drawing.Size(379, 158);
            this.Load += new System.EventHandler(this.CardPerfil_Load);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
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
        private CircularPanel picPerfil;
    }
}
