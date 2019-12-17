using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Domain
{
    public class PdfParser : IParser
    {
        public string DocumentName { get; set; }
        
        public PdfParser(string documentName)
        {
            DocumentName = documentName;

            PdfWriter pdfWriter = new PdfWriter("hello.pdf");
            PdfDocument pdfDocument = new PdfDocument(pdfWriter);
            Document document = new Document(pdfDocument);
        }
    }
}