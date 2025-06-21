namespace Acelera2025.Views
{
    partial class CardPostImagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardPostImagem));
            this.roundedPanel1 = new RoundedPanel();
            this.panelComentarios = new System.Windows.Forms.Panel();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.roundedPanel2 = new RoundedPanel();
            this.picPost2 = new Acelera2025.Ferramentas.RoundedPicture();
            this.picPost1 = new Acelera2025.Ferramentas.RoundedPicture();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.picPerfil = new CircularPanel();
            this.lblCurtidas = new System.Windows.Forms.Label();
            this.btnCurtir = new CircularButton();
            this.btnComentar = new CircularButton();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPost2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPost1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.panelComentarios);
            this.roundedPanel1.Controls.Add(this.txtComentario);
            this.roundedPanel1.Controls.Add(this.roundedPanel2);
            this.roundedPanel1.Controls.Add(this.btnComentar);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(978, 453);
            this.roundedPanel1.TabIndex = 0;
            // 
            // panelComentarios
            // 
            this.panelComentarios.AutoScroll = true;
            this.panelComentarios.Location = new System.Drawing.Point(668, 15);
            this.panelComentarios.Name = "panelComentarios";
            this.panelComentarios.Size = new System.Drawing.Size(289, 376);
            this.panelComentarios.TabIndex = 62;
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.White;
            this.txtComentario.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Location = new System.Drawing.Point(668, 397);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(256, 39);
            this.txtComentario.TabIndex = 1;
            this.txtComentario.Text = "Enviar um Comentário";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundedPanel2.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.BorderSize = 0;
            this.roundedPanel2.Controls.Add(this.picPost2);
            this.roundedPanel2.Controls.Add(this.picPost1);
            this.roundedPanel2.Controls.Add(this.lblData);
            this.roundedPanel2.Controls.Add(this.lblTexto);
            this.roundedPanel2.Controls.Add(this.lblNome);
            this.roundedPanel2.Controls.Add(this.picPerfil);
            this.roundedPanel2.Controls.Add(this.lblCurtidas);
            this.roundedPanel2.Controls.Add(this.btnCurtir);
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.roundedPanel2.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(650, 453);
            this.roundedPanel2.TabIndex = 0;
            // 
            // picPost2
            // 
            this.picPost2.BackColor = System.Drawing.Color.Silver;
            this.picPost2.BorderColor = System.Drawing.Color.Black;
            this.picPost2.BorderRadius = 20;
            this.picPost2.BorderSize = 0;
            this.picPost2.Location = new System.Drawing.Point(345, 157);
            this.picPost2.Name = "picPost2";
            this.picPost2.Size = new System.Drawing.Size(284, 240);
            this.picPost2.TabIndex = 67;
            this.picPost2.TabStop = false;
            // 
            // picPost1
            // 
            this.picPost1.BackColor = System.Drawing.Color.Silver;
            this.picPost1.BorderColor = System.Drawing.Color.Black;
            this.picPost1.BorderRadius = 20;
            this.picPost1.BorderSize = 0;
            this.picPost1.Location = new System.Drawing.Point(36, 157);
            this.picPost1.Name = "picPost1";
            this.picPost1.Size = new System.Drawing.Size(284, 240);
            this.picPost1.TabIndex = 66;
            this.picPost1.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblData.Location = new System.Drawing.Point(563, 39);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(49, 30);
            this.lblData.TabIndex = 65;
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
            this.lblTexto.TabIndex = 64;
            this.lblTexto.Text = "Texto TEXTo";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblNome.Location = new System.Drawing.Point(84, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(74, 36);
            this.lblNome.TabIndex = 63;
            this.lblNome.Text = "Nome ";
            // 
            // picPerfil
            // 
            this.picPerfil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picPerfil.BorderColor = System.Drawing.Color.Black;
            this.picPerfil.BorderSize = 0;
            this.picPerfil.Location = new System.Drawing.Point(23, 24);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(55, 61);
            this.picPerfil.TabIndex = 62;
            // 
            // lblCurtidas
            // 
            this.lblCurtidas.AutoSize = true;
            this.lblCurtidas.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurtidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblCurtidas.Location = new System.Drawing.Point(69, 409);
            this.lblCurtidas.Name = "lblCurtidas";
            this.lblCurtidas.Size = new System.Drawing.Size(77, 27);
            this.lblCurtidas.TabIndex = 59;
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
            this.btnCurtir.Location = new System.Drawing.Point(36, 407);
            this.btnCurtir.Name = "btnCurtir";
            this.btnCurtir.Size = new System.Drawing.Size(27, 25);
            this.btnCurtir.TabIndex = 58;
            this.btnCurtir.UseVisualStyleBackColor = false;
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
            this.btnComentar.Location = new System.Drawing.Point(930, 404);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(27, 28);
            this.btnComentar.TabIndex = 60;
            this.btnComentar.UseVisualStyleBackColor = false;
            // 
            // CardPostImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel1);
            this.Name = "CardPostImagem";
            this.Size = new System.Drawing.Size(978, 453);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPost2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPost1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private CircularButton btnComentar;
        private System.Windows.Forms.Label lblCurtidas;
        private CircularButton btnCurtir;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblNome;
        private CircularPanel picPerfil;
        private Ferramentas.RoundedPicture picPost1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtComentario;
        private Ferramentas.RoundedPicture picPost2;
        private System.Windows.Forms.Panel panelComentarios;
    }
}
