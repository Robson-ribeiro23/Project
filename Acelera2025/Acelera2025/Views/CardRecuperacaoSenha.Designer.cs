namespace Acelera2025.Views
{
    partial class CardRecuperacaoSenha
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
            this.btnFechar = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnReceberCodigo = new RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new RoundedButton();
            this.panelNovaSenha = new System.Windows.Forms.Panel();
            this.btnMostrarSenha = new System.Windows.Forms.Button();
            this.roundedButton2 = new RoundedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNovaSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnFechar.Location = new System.Drawing.Point(561, 15);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(23, 29);
            this.btnFechar.TabIndex = 37;
            this.btnFechar.TabStop = true;
            this.btnFechar.Text = "X";
            this.btnFechar.VisitedLinkColor = System.Drawing.Color.White;
            this.btnFechar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnFechar_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(156, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 48);
            this.label1.TabIndex = 39;
            this.label1.Text = "Recuperação de Senha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.label7.Location = new System.Drawing.Point(42, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 27);
            this.label7.TabIndex = 41;
            this.label7.Text = "Digite seu e-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(46, 120);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(411, 33);
            this.txtEmail.TabIndex = 40;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnReceberCodigo
            // 
            this.btnReceberCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReceberCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.btnReceberCodigo.BorderColor = System.Drawing.Color.Black;
            this.btnReceberCodigo.BorderRadius = 10;
            this.btnReceberCodigo.BorderSize = 0;
            this.btnReceberCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceberCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceberCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReceberCodigo.Location = new System.Drawing.Point(461, 120);
            this.btnReceberCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReceberCodigo.Name = "btnReceberCodigo";
            this.btnReceberCodigo.Size = new System.Drawing.Size(107, 32);
            this.btnReceberCodigo.TabIndex = 42;
            this.btnReceberCodigo.Text = "Receber Código";
            this.btnReceberCodigo.UseVisualStyleBackColor = false;
            this.btnReceberCodigo.Click += new System.EventHandler(this.btnReceberCodigo_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(42, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 27);
            this.label2.TabIndex = 43;
            this.label2.Text = "Digite o Código de 6 dígitos que foi enviado ao seu e-mail:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodigo.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(46, 228);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(148, 33);
            this.txtCodigo.TabIndex = 44;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.btnConfirmar.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.BorderRadius = 10;
            this.btnConfirmar.BorderSize = 0;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmar.Location = new System.Drawing.Point(218, 228);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(107, 32);
            this.btnConfirmar.TabIndex = 45;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panelNovaSenha
            // 
            this.panelNovaSenha.Controls.Add(this.btnMostrarSenha);
            this.panelNovaSenha.Controls.Add(this.roundedButton2);
            this.panelNovaSenha.Controls.Add(this.label3);
            this.panelNovaSenha.Controls.Add(this.txtSenha);
            this.panelNovaSenha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNovaSenha.Location = new System.Drawing.Point(0, 279);
            this.panelNovaSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelNovaSenha.Name = "panelNovaSenha";
            this.panelNovaSenha.Size = new System.Drawing.Size(601, 110);
            this.panelNovaSenha.TabIndex = 46;
            // 
            // btnMostrarSenha
            // 
            this.btnMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMostrarSenha.FlatAppearance.BorderSize = 0;
            this.btnMostrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarSenha.Location = new System.Drawing.Point(427, 50);
            this.btnMostrarSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarSenha.Name = "btnMostrarSenha";
            this.btnMostrarSenha.Size = new System.Drawing.Size(21, 20);
            this.btnMostrarSenha.TabIndex = 48;
            this.btnMostrarSenha.UseVisualStyleBackColor = false;
            this.btnMostrarSenha.Click += new System.EventHandler(this.btnMostrarSenha_Click);
            // 
            // roundedButton2
            // 
            this.roundedButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.roundedButton2.BorderColor = System.Drawing.Color.Black;
            this.roundedButton2.BorderRadius = 10;
            this.roundedButton2.BorderSize = 0;
            this.roundedButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedButton2.Location = new System.Drawing.Point(461, 44);
            this.roundedButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(107, 32);
            this.roundedButton2.TabIndex = 47;
            this.roundedButton2.Text = "Confirmar";
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(42, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 27);
            this.label3.TabIndex = 46;
            this.label3.Text = "Defina sua nova senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenha.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(46, 44);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(377, 33);
            this.txtSenha.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Acelera2025.Properties.Resources.image_removebg_preview__3____Copia;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // CardRecuperacaoSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panelNovaSenha);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReceberCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFechar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CardRecuperacaoSenha";
            this.Size = new System.Drawing.Size(601, 389);
            this.Load += new System.EventHandler(this.CardRecuperacaoSenha_Load);
            this.panelNovaSenha.ResumeLayout(false);
            this.panelNovaSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private RoundedButton btnReceberCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private RoundedButton btnConfirmar;
        private System.Windows.Forms.Panel panelNovaSenha;
        private RoundedButton roundedButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnMostrarSenha;
    }
}
