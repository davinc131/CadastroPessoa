using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainRandonNumber;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;

namespace ViewPessoas
{
    public partial class RandonNumberView : Form
    {
        private RandonNumber randonNumber;
        private RandonNumberRepository randonNumberRepository;
        private Random random;
        public RandonNumberView()
        {
            InitializeComponent();
            random = new Random();
            randonNumberRepository = new RandonNumberRepository();
        }

        private void ButtonSoma_Click(object sender, EventArgs e)
        {
            try
            {
                randonNumberRepository.AddRandonNumber(randonNumber = new RandonNumber(random.Next(1, 99), random.Next(1, 99), "+"));
                textEditNumber01.Text = randonNumber.NumberA.ToString();
                textEditNumber2.Text = randonNumber.NumberB.ToString();
                textEditResponse.Text = randonNumber.Response.ToString();
                gridControl1.DataSource = randonNumberRepository.RandonNumbers;
                gridControl1.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSubtracao_Click(object sender, EventArgs e)
        {
            try
            {
                randonNumberRepository.AddRandonNumber(randonNumber = new RandonNumber(random.Next(1, 99), random.Next(1, 99), "-"));
                textEditNumber01.Text = randonNumber.NumberA.ToString();
                textEditNumber2.Text = randonNumber.NumberB.ToString();
                textEditResponse.Text = randonNumber.Response.ToString();
                gridControl1.DataSource = randonNumberRepository.RandonNumbers;
                gridControl1.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonMultiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                randonNumberRepository.AddRandonNumber(randonNumber = new RandonNumber(random.Next(1, 99), random.Next(1, 99), "*"));
                textEditNumber01.Text = randonNumber.NumberA.ToString();
                textEditNumber2.Text = randonNumber.NumberB.ToString();
                textEditResponse.Text = randonNumber.Response.ToString();
                gridControl1.DataSource = randonNumberRepository.RandonNumbers;
                gridControl1.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonDivisao_Click(object sender, EventArgs e)
        {
            try
            {
                randonNumberRepository.AddRandonNumber(randonNumber = new RandonNumber(random.Next(1, 150), random.Next(1, 99), "/"));
                textEditNumber01.Text = randonNumber.NumberA.ToString();
                textEditNumber2.Text = randonNumber.NumberB.ToString();
                textEditResponse.Text = randonNumber.Response.ToString();
                gridControl1.DataSource = randonNumberRepository.RandonNumbers;
                gridControl1.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GerarTextoAluno()
        {
            string text = "Lista de Exercício";
            text += "\n";

            int i = 0;
            foreach(RandonNumber randon in randonNumberRepository.RandonNumbers)
            {
                text += "\n";
                text += ++i + ") ";
                text += randon.NumberA + " " + randon.Sinal + " " + randon.NumberB + " = ";
                text += "\n";
            }

            return text;
        }

        private string GerarTextoProfessor()
        {
            string text = "Lista de Exercício";
            text += "\n";

            int i = 0;
            foreach (RandonNumber randon in randonNumberRepository.RandonNumbers)
            {
                text += "\n";
                text += ++i + ") ";
                text += randon.NumberA + " " + randon.Sinal + " " + randon.NumberB + " = " + randon.Response;
                text += "\n";
            }

            return text;
        }

        private void GerarPdf(string text, string filename)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);

            XTextFormatter tf = new XTextFormatter(gfx);

            // Draw the text
            tf.DrawString(text, font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormat.TopLeft);

            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);
        }

        private void ButtonPdf_Click(object sender, EventArgs e)
        {
            try
            {
                GerarPdf(GerarTextoAluno(), "ListaAluno.pdf");
                GerarPdf(GerarTextoProfessor(), "ListaProfessor.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
