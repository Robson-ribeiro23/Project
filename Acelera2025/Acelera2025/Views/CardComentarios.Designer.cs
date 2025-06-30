namespace Acelera2025.Views
{
    partial class CardComentarios
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
            this.roundedPanel1 = new RoundedPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.picPerfil = new CircularPanel();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.panel1);
            this.roundedPanel1.Controls.Add(this.lblTexto);
            this.roundedPanel1.Controls.Add(this.lblNome);
            this.roundedPanel1.Controls.Add(this.picPerfil);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(319, 84);
            this.roundedPanel1.TabIndex = 2;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(2, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 2);
            this.panel1.TabIndex = 68;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblTexto.Location = new System.Drawing.Point(42, 34);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(46, 21);
            this.lblTexto.TabIndex = 65;
            this.lblTexto.Text = "Nome ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.lblNome.Location = new System.Drawing.Point(42, 10);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 25);
            this.lblNome.TabIndex = 64;
            this.lblNome.Text = "Nome ";
            // 
            // picPerfil
            // 
            this.picPerfil.BackColor = System.Drawing.Color.Transparent;
            this.picPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPerfil.BorderColor = System.Drawing.Color.Black;
            this.picPerfil.BorderSize = 0;
            this.picPerfil.Location = new System.Drawing.Point(14, 7);
            this.picPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(23, 27);
            this.picPerfil.TabIndex = 0;
            this.picPerfil.Paint += new System.Windows.Forms.PaintEventHandler(this.picPerfil_Paint);
            // 
            // CardComentarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CardComentarios";
            this.Size = new System.Drawing.Size(319, 84);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedPanel roundedPanel1;
        private CircularPanel picPerfil;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
    }
}
