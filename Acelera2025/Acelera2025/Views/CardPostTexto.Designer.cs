namespace Acelera2025.Views
{
    partial class CardPostTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardPostTexto));
            this.roundedPanel1 = new RoundedPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.roundedPanel2 = new RoundedPanel();
            this.picFotoPerfil = new Acelera2025.Views.Tools.CircularPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCurtidas = new System.Windows.Forms.Label();
            this.btnCurtir = new CircularButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnComentar = new CircularButton();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.flowLayoutPanel1);
            this.roundedPanel1.Controls.Add(this.txtComentarios);
            this.roundedPanel1.Controls.Add(this.roundedPanel2);
            this.roundedPanel1.Controls.Add(this.btnComentar);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(890, 304);
            this.roundedPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(557, 19);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 239);
            this.flowLayoutPanel1.TabIndex = 61;
            // 
            // txtComentarios
            // 
            this.txtComentarios.BackColor = System.Drawing.Color.White;
            this.txtComentarios.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarios.Location = new System.Drawing.Point(557, 260);
            this.txtComentarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(296, 33);
            this.txtComentarios.TabIndex = 1;
            this.txtComentarios.Text = "Enviar um Comentário";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.AutoScroll = true;
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundedPanel2.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.BorderSize = 0;
            this.roundedPanel2.Controls.Add(this.picFotoPerfil);
            this.roundedPanel2.Controls.Add(this.panel2);
            this.roundedPanel2.Controls.Add(this.panel1);
            this.roundedPanel2.Controls.Add(this.lblData);
            this.roundedPanel2.Controls.Add(this.lblNome);
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.roundedPanel2.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(553, 304);
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
            this.picFotoPerfil.Location = new System.Drawing.Point(7, 12);
            this.picFotoPerfil.Name = "picFotoPerfil";
            this.picFotoPerfil.Size = new System.Drawing.Size(55, 55);
            this.picFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoPerfil.TabIndex = 60;
            this.picFotoPerfil.TabStop = false;
            this.picFotoPerfil.Click += new System.EventHandler(this.picFotoPerfil_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCurtidas);
            this.panel2.Controls.Add(this.btnCurtir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 269);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 35);
            this.panel2.TabIndex = 67;
            // 
            // lblCurtidas
            // 
            this.lblCurtidas.AutoSize = true;
            this.lblCurtidas.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurtidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblCurtidas.Location = new System.Drawing.Point(50, 5);
            this.lblCurtidas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurtidas.Name = "lblCurtidas";
            this.lblCurtidas.Size = new System.Drawing.Size(62, 21);
            this.lblCurtidas.TabIndex = 59;
            this.lblCurtidas.Text = "X curtidas";
            // 
            // btnCurtir
            // 
            this.btnCurtir.BackColor = System.Drawing.Color.Transparent;
            this.btnCurtir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCurtir.BackgroundImage")));
            this.btnCurtir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCurtir.BorderColor = System.Drawing.Color.Black;
            this.btnCurtir.BorderSize = 0;
            this.btnCurtir.FlatAppearance.BorderSize = 0;
            this.btnCurtir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurtir.Location = new System.Drawing.Point(25, 5);
            this.btnCurtir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCurtir.Name = "btnCurtir";
            this.btnCurtir.Size = new System.Drawing.Size(20, 20);
            this.btnCurtir.TabIndex = 58;
            this.btnCurtir.UseVisualStyleBackColor = false;
            this.btnCurtir.Click += new System.EventHandler(this.btnCurtir_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblTexto);
            this.panel1.Location = new System.Drawing.Point(2, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 135);
            this.panel1.TabIndex = 66;
            // 
            // lblTexto
            // 
            this.lblTexto.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblTexto.Location = new System.Drawing.Point(14, 11);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(520, 118);
            this.lblTexto.TabIndex = 64;
            this.lblTexto.Text = "Texto";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblData.Location = new System.Drawing.Point(413, 32);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(96, 24);
            this.lblData.TabIndex = 65;
            this.lblData.Text = "xx/xx/xxxx";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblNome.Location = new System.Drawing.Point(63, 32);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 29);
            this.lblNome.TabIndex = 63;
            this.lblNome.Text = "Nome ";
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
            this.btnComentar.Location = new System.Drawing.Point(855, 264);
            this.btnComentar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(22, 24);
            this.btnComentar.TabIndex = 60;
            this.btnComentar.UseVisualStyleBackColor = false;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click);
            // 
            // CardPostTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CardPostTexto";
            this.Size = new System.Drawing.Size(890, 304);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.TextBox txtComentarios;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCurtidas;
        private CircularButton btnCurtir;
        private CircularButton btnComentar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Tools.CircularPictureBox picFotoPerfil;
    }
}
