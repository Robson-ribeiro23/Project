using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;

namespace Acelera2025.Telas
{
    public partial class CardBaixarCertificado: UserControl
    {
        public CardBaixarCertificado()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            PreencherModeloPDF("Amanda do Prado Gomes de Carvalho", "123.456.789-00", "Feira Gastronomica do Morango Sulista", "11/06/2025", "3");
            MessageBox.Show("PDF gerado com sucesso!");
        }
        public void PreencherModeloPDF(string nome, string cpf, string nomeEvento, string data, string hora)
        {
            string modeloPDF = "certificado.pdf";
            string novoPDF = $"certificadoConclusao_{nome}.pdf";

            using (PdfReader reader = new PdfReader(modeloPDF))
            using (FileStream fs = new FileStream(novoPDF, FileMode.Create, FileAccess.Write))
            using (PdfStamper stamper = new PdfStamper(reader, fs))
            {
                PdfContentByte cb = stamper.GetOverContent(1);
                BaseFont fonte = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

                cb.BeginText();
                cb.SetFontAndSize(fonte, 16);
                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Certificamos que " + nome + ", portador do CPF: " + cpf, 420, 290, 0);
                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "participou do evento " + nomeEvento, 420, 260, 0);
                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "no dia " + data + ", com carga horária equivalente a " + hora + "horas.", 420, 230, 0);
                cb.EndText();
                stamper.FormFlattening = true;
            }

            if (File.Exists(novoPDF))
            {
                Process.Start(new ProcessStartInfo(novoPDF) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("Erro: O arquivo PDF não foi criado.");
            }
        }

        private void CardBaixarCertificado_Load(object sender, EventArgs e)
        {

        }
    }
    }

