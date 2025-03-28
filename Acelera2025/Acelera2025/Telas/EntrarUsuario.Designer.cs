namespace Acelera2025.Telas
{
    partial class EntrarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntrarEmpresa = new RoundedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new RoundedPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cadastrarEmpresa = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.roundedButton1 = new RoundedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEntrarEmpresa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 693);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::Acelera2025.Properties.Resources.setaBranca;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(31, 26);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(44, 54);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(143, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 58);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cadastrar usuário";
            // 
            // btnEntrarEmpresa
            // 
            this.btnEntrarEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEntrarEmpresa.BackColor = System.Drawing.SystemColors.Control;
            this.btnEntrarEmpresa.BorderColor = System.Drawing.Color.Black;
            this.btnEntrarEmpresa.BorderRadius = 10;
            this.btnEntrarEmpresa.BorderSize = 0;
            this.btnEntrarEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrarEmpresa.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.btnEntrarEmpresa.Location = new System.Drawing.Point(187, 356);
            this.btnEntrarEmpresa.Name = "btnEntrarEmpresa";
            this.btnEntrarEmpresa.Size = new System.Drawing.Size(190, 40);
            this.btnEntrarEmpresa.TabIndex = 7;
            this.btnEntrarEmpresa.Text = "Cadastrar";
            this.btnEntrarEmpresa.UseVisualStyleBackColor = false;
            this.btnEntrarEmpresa.Click += new System.EventHandler(this.btnEntrarEmpresa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.roundedPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(564, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 693);
            this.panel2.TabIndex = 3;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.textBox1);
            this.roundedPanel1.Controls.Add(this.textBox3);
            this.roundedPanel1.Controls.Add(this.cadastrarEmpresa);
            this.roundedPanel1.Controls.Add(this.label7);
            this.roundedPanel1.Controls.Add(this.roundedButton1);
            this.roundedPanel1.Controls.Add(this.label5);
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Location = new System.Drawing.Point(103, 125);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(581, 459);
            this.roundedPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(74, 277);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 35);
            this.textBox1.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(74, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(439, 35);
            this.textBox3.TabIndex = 11;
            // 
            // cadastrarEmpresa
            // 
            this.cadastrarEmpresa.ActiveLinkColor = System.Drawing.Color.Firebrick;
            this.cadastrarEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cadastrarEmpresa.AutoSize = true;
            this.cadastrarEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrarEmpresa.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarEmpresa.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.cadastrarEmpresa.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.cadastrarEmpresa.Location = new System.Drawing.Point(253, 404);
            this.cadastrarEmpresa.Name = "cadastrarEmpresa";
            this.cadastrarEmpresa.Size = new System.Drawing.Size(90, 30);
            this.cadastrarEmpresa.TabIndex = 17;
            this.cadastrarEmpresa.TabStop = true;
            this.cadastrarEmpresa.Text = "Recuperar";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.label7.Location = new System.Drawing.Point(68, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Esqueceu sua senha?";
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(136)))), ((int)(((byte)(107)))));
            this.roundedButton1.BorderColor = System.Drawing.Color.Black;
            this.roundedButton1.BorderRadius = 10;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedButton1.Location = new System.Drawing.Point(194, 343);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(190, 40);
            this.roundedButton1.TabIndex = 15;
            this.roundedButton1.Text = "Entrar";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(68, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(77, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(133, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Entrar como Usuário";
            // 
            // EntrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 693);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EntrarUsuario";
            this.Text = "EntrarUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label2;
        private RoundedButton btnEntrarEmpresa;
        private System.Windows.Forms.Panel panel2;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.LinkLabel cadastrarEmpresa;
        private System.Windows.Forms.Label label7;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}