using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class H1 : IText
    {
        /// <summary>
        /// H2 is similar to a title (Name at the beginning of the resume for example)
        /// </summary>
        #region Properties
        public virtual int Id { get; set; }
        public virtual Container Container { get; set; }
        public virtual string Content { get; set; }
        public virtual bool VisibilityParser { get; set; }

        // Style properties
        public virtual bool Italic { get; set; }
        public virtual bool Bold { get; set; }
        public virtual int Size { get; set; }
        public virtual string ForegroundColor { get; set; }
        public virtual string BackgroundColor { get; set; }
        #endregion


        #region Constructors

        /// Constructeur sans paramètre nécesessaire pour NHibernate
        /// </summary>
        public H1() { }
        /// Empty parameter constructor needed by NHibernate
        /// </summary>
        public H1()
        {
            VisibilityParser = true;
            Size = 24;
            Content = "";
            ForegroundColor = "";
            BackgroundColor = "";
        }

        public H1(string content, Container container) : this()
        {
            Content = content;
            Container = container;
        }
        #endregion


        #region Methods

        public override string ToString()
        {
            return Content;
        }

        public virtual IElement Copy()
        {
            H1 copy = new H1();

            copy.Container = Container;
            copy.Content = Content;
            copy.Italic = Italic;
            copy.Bold = Bold;
            copy.Size = Size;
            copy.ForegroundColor = ForegroundColor;
            copy.BackgroundColor = BackgroundColor;

            return copy;
        }
        public virtual string StylingCSS()
        {
            string style = "";
            style += (Italic ? "font-style: italic;" : "");
            style += (Bold ? "font-weight: 700;" : "");
            style += "font-size: " + Size + "px";
            style += "color: " + ForegroundColor;
            style += "background-color: " + BackgroundColor;

            return style;
        }
        #endregion
    }
}