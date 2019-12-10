using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace ParserTests
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PdfWriter pdfWriter = new PdfWriter("hello.pdf"))
            using (PdfDocument pdfDocument = new PdfDocument(pdfWriter))
            using (Document document = new Document(pdfDocument))
            {
                document.Add(new Paragraph("Hello World!"));
            }
        }
    }
}
