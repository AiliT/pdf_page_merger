using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "Odota.";

            string originPath = originPathTextBox.Text;
            string resultFileName = resultPathTextBox.Text;
            string textToFind = textToSearchTextBox.Text;

            if (originPath == "" || resultFileName == "" || textToFind == "")
            {
                resultLabel.Text = "Puuttuva teksti.";
                return;
            }

            if (!Directory.Exists(originPath))
            {
                resultLabel.Text = $"Kansio {originPath} ei löytynyt.";
                return;
            }

            resultLabel.Text = CreatePdf(resultFileName, originPath, textToFind);
        }


        private string CreatePdf(string resultFileName, string originPath, string textToFind)
        {
            PdfDocument? resultDocument = null;
            try
            {
                resultDocument = new PdfDocument(new PdfWriter(resultFileName));

                foreach (string fileName in Directory.EnumerateFiles(originPath, "*.pdf"))
                {
                    PdfDocument? document = null;
                    try
                    {
                        document = new PdfDocument(new PdfReader(fileName));

                        for (int i = 1; i <= document.GetNumberOfPages(); i++)
                        {
                            PdfPage page = document.GetPage(i);
                            string text = PdfTextExtractor.GetTextFromPage(page);

                            if (text.Contains(textToFind, StringComparison.OrdinalIgnoreCase))
                            {
                                document.CopyPagesTo(i, i, resultDocument);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                    finally
                    {
                        document?.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                resultDocument?.Close();
            }

            return "Valmis.";
        }
    }
}