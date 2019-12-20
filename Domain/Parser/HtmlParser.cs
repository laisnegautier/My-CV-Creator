using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;

namespace Domain
{
    /// <summary>
    /// PaserHTML can transform a resume into an HTML file
    /// </summary>
    public class HtmlParser : IParser
    {
        #region Properties
        public string DocumentName { get; set; }
        public string Content { get; set; }
        public Resume Resume { get; set; }
        #endregion

        #region Constructors
        public HtmlParser(Resume resume)
        {
            Content = "";
            Resume = resume;
            DocumentName = resume.Title;
        }

        public HtmlParser(Resume resume, string documentName) : this(resume)
        {
            DocumentName = documentName;
        }
        #endregion

        #region Methods
        public bool ParseToHtml()
        {
            bool success = false;

            string fileName = DocumentName + ".html";

            string head = "<!DOCTYPE html><html><head><title='" + Resume.Title + "'></head><body style=\"width:70%;margin: auto;font-family: Calibri;\">";
            string bottom = "</body></html>";
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.WriteLine(head);

                    if (Resume.Containers.Count > 0)
                        foreach (Container c in Resume.Containers)
                        {
                            sw.WriteLine("<h2>" + c.Name + "</h2>");

                            if (c.VisibilityParser && c.Elements.Count > 0)
                            {
                                Content += c.Name;

                                foreach (IElement e in c.Elements)
                                    if (e.VisibilityParser)
                                    {
                                        if (e is Line) sw.WriteLine("<hr style=\"" + e.StylingCSS() + "\" >");
                                        else if (e is Paragraph) sw.WriteLine("<p style=\"" + e.StylingCSS() + "\">" + e.ToString() + "</p>");
                                        else if (e is H1) sw.WriteLine("<h1 style=\"" + e.StylingCSS() + "\">" + e.ToString() + "</h1>");
                                        else if (e is H2) sw.WriteLine("<h2 style=\"" + e.StylingCSS() + "\">" + e.ToString() + "</h2>");
                                        else if (e is Date) sw.WriteLine("<p style=\"" + e.StylingCSS() + "\">" + e.ToString() + "</p>");
                                        Content += e.ToString() + "\n";
                                    }
                            }
                        }

                    sw.WriteLine(bottom);
                }
                // Encode the string for special caracters (<, \, & ...)
                string encodedHtml = HttpUtility.HtmlEncode(Content);

                success = true;
            }
            catch (Exception e)
            {
                success = false;
            }

            return success;
        }
        #endregion
    }
}