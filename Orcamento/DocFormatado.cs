using NReco.PdfGenerator;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Orcamento
{
    public partial class DocFormatado : Form
    {
        HTML doc = new HTML();

        public DocFormatado()
        {
            InitializeComponent();            
        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();            
        }
        
        private void DocFormatado_Load(object sender, System.EventArgs e)
        {
            doc.buildHtml();
            webBrowser1.DocumentText = doc.HtmlCode.Replace(doc.PageNumber, "");            
        }
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            geraPdf();            
        }
        
        private void geraPdf()//Gera o documento PDF 
        {
            string orcHtml = doc.HtmlCode.ToString();
            //remove o header para não bugar o PDF
            orcHtml = doc.HtmlCode.Replace(doc.HeaderCode,"");                      
           
            saveDlg.Title = "Salvar como PDF";
            saveDlg.Filter = "Arquivo PDF|.pdf";
            saveDlg.FileName = "Orçamento - " + CadOrc.dadosCliente[0];
            saveDlg.DefaultExt = ".pdf";
            DialogResult resultado = saveDlg.ShowDialog();
            if (resultado == DialogResult.OK)
            {                
                HtmlToPdfConverter pdfConverter = new HtmlToPdfConverter();    
                //Acrescenta pageNumber e Header dinâmicos            
                pdfConverter.PageHeaderHtml = doc.PageNumber + doc.HeaderCode;
                
                var pdfBytes = pdfConverter.GeneratePdf(orcHtml);                
                string nomeArquivo = saveDlg.FileName;
                File.WriteAllBytes(nomeArquivo, pdfBytes);
            }
        }

        private void enviarPorEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Este recurso ainda não foi implementado.", "Informação:");
        }
    }
}
