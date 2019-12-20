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
        public bool Parse()
        {
            bool success = false;

            string fileName = DocumentName + ".html";

            string head = "<!DOCTYPE html>" +
                "<html>" +
                "<head>" +
                "<title>" + Resume.Title + "</title>" +
                "<style>" +
                "html{}" +
                "body{width:70%;margin: auto;font-family: Calibri; background-color: white;}" +
                "h1{line-height: 1.2ft}" +
                "h2{line-height: 1.2ft; margin-top: 0px;}" +
                ".entete{overflow: hidden; background: white; box-shadow: 5px 5px 0px lightgray; border-color: gray; font-size: 14px; border: 1px solid lightgray; padding: 0px; margin: 20px auto;}" +
                ".titreEntete{font-size: 20px; background-color: #f3f3f3; padding: 10px 20px; text-transform: uppercase; font-weight: 500;}" +
                "p{font-size: 16px; text-align:justify; line-height:3px;}" +
                ".date{width: auto; color: gray; display: inline-block; border: 1px solid lightgray; padding: 5px 10px; margin: 10px 0 0 0;}" +
                ".contenu{padding: 10px 20px 10px 20px;}" +
                "</style>" +
                "</head>" +
                "<body>";
            string bottom = "</body></html>";
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.WriteLine(head);

                    if (Resume.Containers.Count > 0)
                        foreach (Container c in Resume.Containers)
                        {
                            sw.WriteLine("<div class='entete'><div class='titreEntete'>" + c.Name + "</div><div class='contenu'>");

                            if (c.VisibilityParser && c.Elements.Count > 0)
                            {
                                Content += c.Name;

                                foreach (IElement e in c.Elements)
                                    if (e.VisibilityParser)
                                    {
                                        if (e.GetType() == typeof(Line)) sw.WriteLine("<hr style=\"" + e.StylingCSS() + "\" >");
                                        else if (e.GetType() == typeof(Paragraph)) sw.WriteLine("<p style='" + e.StylingCSS() + "'>" + e.ToString() + "</p>");
                                        else if (e.GetType() == typeof(H1)) sw.WriteLine("<h1 style=\"" + e.StylingCSS() + "\">" + e.ToString() + "</h1>");
                                        else if (e.GetType() == typeof(H2)) sw.WriteLine("<h2 style=\"" + e.StylingCSS() + "\">" + e.ToString() + "</h2>");
                                        else if (e.GetType() == typeof(Date)) sw.WriteLine("<h3 class='date' style=\"" + e.StylingCSS() + "\">" + e.ToString() + "</h3>");
                                        Content += e.ToString() + "\n";
                                    }

                            }
                            sw.WriteLine("</div></div>");
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