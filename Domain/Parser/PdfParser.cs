using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
        public bool ParseToPdf()
        {
            bool success = false;
            
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
             try
             {
                PdfWriter.GetInstance(doc, new FileStream(DocumentName, FileMode.Create));
                doc.Open();
                doc.Add(new iTextSharp.text.Paragraph(Content));

                if (Resume.Containers.Count > 0)
                    foreach (Container c in Resume.Containers)
                    {
                        doc.Add(new iTextSharp.text.Paragraph(c.Name));

                        if (c.VisibilityParser && c.Elements.Count > 0)
                        {
                            Content += c.Name;

                            foreach (IElement e in c.Elements)
                                if (e.VisibilityParser)
                                {
                                    if (e is Line) doc.Add(new iTextSharp.text.Paragraph(e.ToString()));
                                    else if (e is Paragraph) doc.Add(new iTextSharp.text.Paragraph(e.ToString()));
                                    else if (e is H1) doc.Add(new iTextSharp.text.Paragraph(e.ToString()));
                                    else if (e is H2) doc.Add(new iTextSharp.text.Paragraph(e.ToString()));
                                    else if (e is Date) doc.Add(new iTextSharp.text.Paragraph(e.ToString()));
                                    Content += e.ToString() + "\n";
                                }
                        }
                    }
            }
            catch (Exception e)
            {
                success = false;

            }
            finally
            {
                doc.Close();
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