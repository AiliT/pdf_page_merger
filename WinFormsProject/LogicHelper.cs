using DAL;
using iText.Kernel.Pdf;

namespace WinFormsProject
{
    internal static class LogicHelper
    {
        public static string CreatePdfFromMatchingPages(string resultFileName, string originPath, string textToFind)
        {
            PdfDocument resultDocument = null;
            try
            {
                resultDocument = new PdfDocument(new PdfWriter($"{resultFileName}.pdf"));
                foreach (string fileName in Directory.EnumerateFiles(originPath, "*.pdf").OrderBy(item => item))
                {
                    using (var document = new PdfSearchableDocument(fileName))
                    {
                        var pageNumber = document.GetPageNumberContainingString(textToFind);
                        document.CopyPageTo(pageNumber, resultDocument);
                    }
                }

                return "Valmis.";
            }
            catch (Exception ex)
            {
                resultDocument?.Close();
                return ex.Message;
            }
        }
    }
}
