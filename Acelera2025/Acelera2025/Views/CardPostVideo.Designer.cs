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
            this.panelComentarios = new System.Windows.Forms.Panel();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.btnComentar = new CircularButton();
            this.roundedPanel2 = new RoundedPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.video = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.picPerfil = new CircularPanel();
            this.lblCurtidas = new System.Windows.Forms.Label();
            this.btnCurtir = new CircularButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
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
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1186, 500);
            this.roundedPanel1.TabIndex = 0;
            // 
            // panelComentarios
            // 
            this.panelComentarios.AutoScroll = true;
            this.panelComentarios.Location = new System.Drawing.Point(666, 22);
            this.panelComentarios.Name = "panelComentarios";
            this.panelComentarios.Size = new System.Drawing.Size(0, 0);
            this.panelComentarios.TabIndex = 63;
            // 
            // txtComentarios
            // 
            this.txtComentarios.BackColor = System.Drawing.Color.White;
            this.txtComentarios.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarios.Location = new System.Drawing.Point(743, 443);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(389, 39);
            this.txtComentarios.TabIndex = 61;
            this.txtComentarios.Text = "Enviar um Comentário";
            // 
            // btnComentar
            // 
            this.btnComentar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.btnComentar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComentar.BorderColor = System.Drawing.Color.Black;
            this.btnComentar.BorderSize = 0;
            this.btnComentar.FlatAppearance.BorderSize = 0;
            this.btnComentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComentar.Image = ((System.Drawing.Image)(resources.GetObject("btnComentar.Image")));
            this.btnComentar.Location = new System.Drawing.Point(1138, 445);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(27, 28);
            this.btnComentar.TabIndex = 62;
            this.btnComentar.UseVisualStyleBackColor = false;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundedPanel2.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.BorderSize = 0;
            this.roundedPanel2.Controls.Add(this.panel1);
            this.roundedPanel2.Controls.Add(this.lblData);
            this.roundedPanel2.Controls.Add(this.lblTexto);
            this.roundedPanel2.Controls.Add(this.lblNome);
            this.roundedPanel2.Controls.Add(this.picPerfil);
            this.roundedPanel2.Controls.Add(this.lblCurtidas);
            this.roundedPanel2.Controls.Add(this.btnCurtir);
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.roundedPanel2.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(737, 500);
            this.roundedPanel2.TabIndex = 0;
            this.roundedPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.video);
            this.panel1.Location = new System.Drawing.Point(90, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 239);
            this.panel1.TabIndex = 71;
            // 
            // video
            // 
            this.video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.video.Enabled = true;
            this.video.Location = new System.Drawing.Point(0, 0);
            this.video.Name = "video";
            this.video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video.OcxState")));
            this.video.Size = new System.Drawing.Size(566, 239);
            this.video.TabIndex = 70;
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
            this.lblTexto.Location = new System.Drawing.Point(26, 95);
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
            // picPerfil
            // 
            this.picPerfil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picPerfil.BorderColor = System.Drawing.Color.Black;
            this.picPerfil.BorderSize = 0;
            this.picPerfil.Location = new System.Drawing.Point(23, 22);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(55, 61);
            this.picPerfil.TabIndex = 66;
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
            this.btnCurtir.Name = "btnCurtir";
            this.btnCurtir.Size = new System.Drawing.Size(27, 25);
            this.btnCurtir.TabIndex = 60;
            this.btnCurtir.UseVisualStyleBackColor = false;
            this.btnCurtir.Click += new System.EventHandler(this.btnCurtir_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(743, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(425, 411);
            this.flowLayoutPanel1.TabIndex = 64;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // CardPostVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel1);
            this.Name = "CardPostVideo";
            this.Size = new System.Drawing.Size(1186, 500);
            this.Load += new System.EventHandler(this.CardPostVideo_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
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
        private CircularPanel picPerfil;
        private System.Windows.Forms.Panel panelComentarios;
        private AxWMPLib.AxWindowsMediaPlayer video;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
