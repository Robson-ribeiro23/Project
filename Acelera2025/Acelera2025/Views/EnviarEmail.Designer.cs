namespace Acelera2025.Views
{
    partial class EnviarEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarEmail));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sendEmail = new RoundedButton();
            this.fechar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailDoDono = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.fechar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(145, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 27);
            this.label2.TabIndex = 38;
            this.label2.Text = "Contate o dono do evento!";
            // 
            // sendEmail
            // 
            this.sendEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.sendEmail.BorderColor = System.Drawing.Color.Black;
            this.sendEmail.BorderRadius = 10;
            this.sendEmail.BorderSize = 0;
            this.sendEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sendEmail.Location = new System.Drawing.Point(179, 438);
            this.sendEmail.Margin = new System.Windows.Forms.Padding(2);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(124, 29);
            this.sendEmail.TabIndex = 37;
            this.sendEmail.Text = "Enviar";
            this.sendEmail.UseVisualStyleBackColor = false;
            this.sendEmail.Click += new System.EventHandler(this.sendEmail_Click);
            // 
            // fechar
            // 
            this.fechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fechar.Controls.Add(this.button1);
            this.fechar.Controls.Add(this.label2);
            this.fechar.Controls.Add(this.label4);
            this.fechar.Controls.Add(this.txtAssunto);
            this.fechar.Controls.Add(this.label3);
            this.fechar.Controls.Add(this.txtTexto);
            this.fechar.Controls.Add(this.label1);
            this.fechar.Controls.Add(this.EmailDoDono);
            this.fechar.Controls.Add(this.pictureBox1);
            this.fechar.Location = new System.Drawing.Point(0, 0);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(489, 493);
            this.fechar.TabIndex = 40;
            this.fechar.Paint += new System.Windows.Forms.PaintEventHandler(this.fechar_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(464, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(34, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 27);
            this.label4.TabIndex = 46;
            this.label4.Text = "Menssagem:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAssunto.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto.Location = new System.Drawing.Point(39, 154);
            this.txtAssunto.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssunto.Multiline = true;
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(410, 30);
            this.txtAssunto.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(34, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 27);
            this.label3.TabIndex = 44;
            this.label3.Text = "Assunto:";
            // 
            // txtTexto
            // 
            this.txtTexto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTexto.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(39, 239);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(2);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(410, 186);
            this.txtTexto.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(34, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 27);
            this.label1.TabIndex = 42;
            this.label1.Text = "Para:";
            // 
            // EmailDoDono
            // 
            this.EmailDoDono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailDoDono.AutoSize = true;
            this.EmailDoDono.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailDoDono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.EmailDoDono.Location = new System.Drawing.Point(82, 91);
            this.EmailDoDono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailDoDono.Name = "EmailDoDono";
            this.EmailDoDono.Size = new System.Drawing.Size(190, 27);
            this.EmailDoDono.TabIndex = 41;
            this.EmailDoDono.Text = "EmailDoDono@gmail.com";
            // 
            // EnviarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sendEmail);
            this.Controls.Add(this.fechar);
            this.Name = "EnviarEmail";
            this.Size = new System.Drawing.Size(489, 493);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.fechar.ResumeLayout(false);
            this.fechar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private RoundedButton sendEmail;
        private System.Windows.Forms.Panel fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmailDoDono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button button1;
    }
}
