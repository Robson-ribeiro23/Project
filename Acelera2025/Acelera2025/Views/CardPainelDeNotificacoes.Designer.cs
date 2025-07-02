namespace Acelera2025.Telas
{
    partial class CardPainelDeNotificacoes
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
            this.label10 = new System.Windows.Forms.Label();
            this.panelNotificacao = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(97)))), ((int)(((byte)(153)))));
            this.label10.Location = new System.Drawing.Point(11, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 34);
            this.label10.TabIndex = 5;
            this.label10.Text = "Notificações";
            // 
            // panelNotificacao
            // 
            this.panelNotificacao.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelNotificacao.Location = new System.Drawing.Point(16, 60);
            this.panelNotificacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelNotificacao.Name = "panelNotificacao";
            this.panelNotificacao.Size = new System.Drawing.Size(234, 398);
            this.panelNotificacao.TabIndex = 6;
            // 
            // CardPainelDeNotificacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panelNotificacao);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CardPainelDeNotificacoes";
            this.Size = new System.Drawing.Size(272, 480);
            this.Load += new System.EventHandler(this.CardPainelDeNotificacoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel panelNotificacao;
    }
}
