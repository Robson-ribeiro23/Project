namespace Acelera2025.Views
{
    partial class PostsCard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.roundedPicture2 = new Acelera2025.Ferramentas.RoundedPicture();
            this.roundedPicture1 = new Acelera2025.Ferramentas.RoundedPicture();
            this.circularButton1 = new CircularButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.circularButton1);
            this.panel2.Controls.Add(this.roundedPicture1);
            this.panel2.Controls.Add(this.roundedPicture2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1279, 552);
            this.panel2.TabIndex = 1;
            // 
            // roundedPicture2
            // 
            this.roundedPicture2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPicture2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundedPicture2.BorderColor = System.Drawing.Color.Black;
            this.roundedPicture2.BorderRadius = 20;
            this.roundedPicture2.BorderSize = 0;
            this.roundedPicture2.Location = new System.Drawing.Point(3, 3);
            this.roundedPicture2.Name = "roundedPicture2";
            this.roundedPicture2.Size = new System.Drawing.Size(1273, 543);
            this.roundedPicture2.TabIndex = 61;
            this.roundedPicture2.TabStop = false;
            // 
            // roundedPicture1
            // 
            this.roundedPicture1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(207)))), ((int)(((byte)(214)))));
            this.roundedPicture1.BorderColor = System.Drawing.Color.Black;
            this.roundedPicture1.BorderRadius = 30;
            this.roundedPicture1.BorderSize = 0;
            this.roundedPicture1.Dock = System.Windows.Forms.DockStyle.Left;
            this.roundedPicture1.Location = new System.Drawing.Point(0, 0);
            this.roundedPicture1.Name = "roundedPicture1";
            this.roundedPicture1.Size = new System.Drawing.Size(695, 552);
            this.roundedPicture1.TabIndex = 62;
            this.roundedPicture1.TabStop = false;
            // 
            // circularButton1
            // 
            this.circularButton1.BorderColor = System.Drawing.Color.Black;
            this.circularButton1.BorderSize = 0;
            this.circularButton1.Location = new System.Drawing.Point(31, 29);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(55, 56);
            this.circularButton1.TabIndex = 63;
            this.circularButton1.Text = "circularButton1";
            this.circularButton1.UseVisualStyleBackColor = true;
            // 
            // PostsCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel2);
            this.Name = "PostsCard";
            this.Size = new System.Drawing.Size(1279, 552);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundedPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPicture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Ferramentas.RoundedPicture roundedPicture1;
        private Ferramentas.RoundedPicture roundedPicture2;
        private CircularButton circularButton1;
    }
}
