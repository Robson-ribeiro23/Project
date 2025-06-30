namespace Acelera2025.Views
{
    partial class CardPostVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardPostVideo));
            this.roundedPanel1 = new RoundedPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelComentarios = new System.Windows.Forms.Panel();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.btnComentar = new CircularButton();
            this.roundedPanel2 = new RoundedPanel();
            this.picFotoPerfil = new Acelera2025.Views.Tools.CircularPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExpandir = new RoundedButton();
            this.video = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCurtidas = new System.Windows.Forms.Label();
            this.btnCurtir = new CircularButton();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.flowLayoutPanel1);
            this.roundedPanel1.Controls.Add(this.panelComentarios);
            this.roundedPanel1.Controls.Add(this.txtComentarios);
            this.roundedPanel1.Controls.Add(this.btnComentar);
            this.roundedPanel1.Controls.Add(this.roundedPanel2);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1187, 500);
            this.roundedPanel1.TabIndex = 0;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(743, 22);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(425, 411);
            this.flowLayoutPanel1.TabIndex = 64;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panelComentarios
            // 
            this.panelComentarios.AutoScroll = true;
            this.panelComentarios.Location = new System.Drawing.Point(667, 22);
            this.panelComentarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelComentarios.Name = "panelComentarios";
            this.panelComentarios.Size = new System.Drawing.Size(0, 0);
            this.panelComentarios.TabIndex = 63;
            // 
            // txtComentarios
            // 
            this.txtComentarios.BackColor = System.Drawing.Color.White;
            this.txtComentarios.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarios.Location = new System.Drawing.Point(743, 443);
            this.txtComentarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(389, 39);
            this.txtComentarios.TabIndex = 61;
            this.txtComentarios.Text = "Enviar um Comentário";
            // 
            // btnComentar
            // 
            this.btnComentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.btnComentar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComentar.BorderColor = System.Drawing.Color.Black;
            this.btnComentar.BorderSize = 0;
            this.btnComentar.FlatAppearance.BorderSize = 0;
            this.btnComentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComentar.Image = ((System.Drawing.Image)(resources.GetObject("btnComentar.Image")));
            this.btnComentar.Location = new System.Drawing.Point(1139, 446);
            this.btnComentar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(30, 30);
            this.btnComentar.TabIndex = 62;
            this.btnComentar.UseVisualStyleBackColor = false;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundedPanel2.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel2.BorderRadius = 1;
            this.roundedPanel2.BorderSize = 0;
            this.roundedPanel2.Controls.Add(this.picFotoPerfil);
            this.roundedPanel2.Controls.Add(this.panel1);
            this.roundedPanel2.Controls.Add(this.lblData);
            this.roundedPanel2.Controls.Add(this.lblTexto);
            this.roundedPanel2.Controls.Add(this.lblNome);
            this.roundedPanel2.Controls.Add(this.lblCurtidas);
            this.roundedPanel2.Controls.Add(this.btnCurtir);
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.roundedPanel2.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(737, 500);
            this.roundedPanel2.TabIndex = 0;
            this.roundedPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel2_Paint);
            // 
            // picFotoPerfil
            // 
            this.picFotoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.picFotoPerfil.BackgroundImage = global::Acelera2025.Properties.Resources.icons8_test_account_48__1_;
            this.picFotoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFotoPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picFotoPerfil.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picFotoPerfil.BorderColor2 = System.Drawing.Color.HotPink;
            this.picFotoPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picFotoPerfil.BorderSize = 2;
            this.picFotoPerfil.GradientAngle = 50F;
            this.picFotoPerfil.Location = new System.Drawing.Point(8, 22);
            this.picFotoPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picFotoPerfil.Name = "picFotoPerfil";
            this.picFotoPerfil.Size = new System.Drawing.Size(69, 69);
            this.picFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoPerfil.TabIndex = 72;
            this.picFotoPerfil.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExpandir);
            this.panel1.Controls.Add(this.video);
            this.panel1.Location = new System.Drawing.Point(33, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 313);
            this.panel1.TabIndex = 71;
            // 
            // btnExpandir
            // 
            this.btnExpandir.BackColor = System.Drawing.Color.Transparent;
            this.btnExpandir.BackgroundImage = global::Acelera2025.Properties.Resources.icons8_expand_100;
            this.btnExpandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpandir.BorderColor = System.Drawing.Color.Transparent;
            this.btnExpandir.BorderRadius = 5;
            this.btnExpandir.BorderSize = 2;
            this.btnExpandir.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandir.Location = new System.Drawing.Point(559, 273);
            this.btnExpandir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(40, 32);
            this.btnExpandir.TabIndex = 71;
            this.btnExpandir.UseVisualStyleBackColor = false;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandirVideo_Click);
            // 
            // video
            // 
            this.video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.video.Enabled = true;
            this.video.Location = new System.Drawing.Point(0, 0);
            this.video.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.video.Name = "video";
            this.video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video.OcxState")));
            this.video.Size = new System.Drawing.Size(623, 313);
            this.video.TabIndex = 70;
            this.video.Enter += new System.EventHandler(this.video_Enter);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblData.Location = new System.Drawing.Point(523, 37);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(49, 30);
            this.lblData.TabIndex = 69;
            this.lblData.Text = "Data";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblTexto.Location = new System.Drawing.Point(27, 95);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(122, 36);
            this.lblTexto.TabIndex = 68;
            this.lblTexto.Text = "Texto TEXTo";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblNome.Location = new System.Drawing.Point(84, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(74, 36);
            this.lblNome.TabIndex = 67;
            this.lblNome.Text = "Nome ";
            // 
            // lblCurtidas
            // 
            this.lblCurtidas.AutoSize = true;
            this.lblCurtidas.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurtidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblCurtidas.Location = new System.Drawing.Point(65, 458);
            this.lblCurtidas.Name = "lblCurtidas";
            this.lblCurtidas.Size = new System.Drawing.Size(77, 27);
            this.lblCurtidas.TabIndex = 61;
            this.lblCurtidas.Text = "X curtidas";
            // 
            // btnCurtir
            // 
            this.btnCurtir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurtir.BackColor = System.Drawing.Color.Transparent;
            this.btnCurtir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCurtir.BackgroundImage")));
            this.btnCurtir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCurtir.BorderColor = System.Drawing.Color.Black;
            this.btnCurtir.BorderSize = 0;
            this.btnCurtir.FlatAppearance.BorderSize = 0;
            this.btnCurtir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurtir.Location = new System.Drawing.Point(23, 457);
            this.btnCurtir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCurtir.Name = "btnCurtir";
            this.btnCurtir.Size = new System.Drawing.Size(27, 25);
            this.btnCurtir.TabIndex = 60;
            this.btnCurtir.UseVisualStyleBackColor = false;
            this.btnCurtir.Click += new System.EventHandler(this.btnCurtir_Click);
            // 
            // CardPostVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CardPostVideo";
            this.Size = new System.Drawing.Size(1187, 500);
            this.Load += new System.EventHandler(this.CardPostVideo_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.video)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.TextBox txtComentarios;
        private CircularButton btnComentar;
        private System.Windows.Forms.Label lblCurtidas;
        private CircularButton btnCurtir;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panelComentarios;
        private AxWMPLib.AxWindowsMediaPlayer video;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Tools.CircularPictureBox picFotoPerfil;
        private RoundedButton btnExpandir;
    }
}
