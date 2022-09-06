using System;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;

namespace DAL
{
    public class PdfSearchableDocument : ISearchableDocument<PdfDocument>
    {
        protected PdfDocument Document;

        public PdfSearchableDocument(string filename)
        {
            Document = new PdfDocument(new PdfReader(filename));
        }

        public void CopyPageTo(int pageNumber, PdfDocument otherDocument)
        {
            Document.CopyPagesTo(pageNumber, pageNumber, otherDocument);
        }

        public void Dispose()
        {
            Document?.Close();
        }

        public int GetPageNumberContainingString(string searchString)
        {
            for (int i = 1; i <= Document.GetNumberOfPages(); i++)
            {
                PdfPage page = Document.GetPage(i);
                string text = PdfTextExtractor.GetTextFromPage(page);

                if (text.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }

            throw new InvalidOperationException($"Given string \"{searchString}\" was not found in document.");
        }
    }
}
