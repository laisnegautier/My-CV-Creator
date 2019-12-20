using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using IronPdf;

namespace Domain
{
    public class PdfParser : IParser
    { 
        #region Properties
        public string DocumentName { get; set; }
        public string Content { get; set; }
        public Resume Resume { get; set; }
        #endregion

        #region Constructors
        public PdfParser(Resume resume)
        {
            Content = "";
            Resume = resume;
            DocumentName = resume.Title;
        }

        public PdfParser(Resume resume, string documentName) : this(resume)
        {
            DocumentName = documentName;
        }
        #endregion

        #region Methods
        public bool Parse()
        {
            bool success = false;

            try
            {
                var Renderer = new IronPdf.HtmlToPdf();

                IParser ToHTML = new HtmlParser(Resume, "convertion");
                ((HtmlParser)ToHTML).Parse(100);
                var doc = Renderer.RenderHTMLFileAsPdf("convertion.html");
                
                doc.SaveAs(DocumentName + ".pdf");
            }
            catch (Exception e)
            {
                success = false;
            }
                
            /*
            PdfWriter pdfWriter = new PdfWriter("hello.pdf");
            PdfDocument pdfDocument = new PdfDocument(pdfWriter);
            Document document = new Document(pdfDocument);

            string fileName = DocumentName + ".html";
            */
            success = true;

            return success;
        }
        #endregion
    }
}