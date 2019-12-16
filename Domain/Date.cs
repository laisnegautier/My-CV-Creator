using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    /// <summary>
    /// A date is used to describe when an event occured (generally written before a Paragraph)
    /// </summary>
    public class Date : IText
    {
        #region Properties
        public virtual int Id { get; set; }
        public virtual Container Container { get; set; }
        public virtual DateTime Content { get; set; }
        public virtual bool VisibilityParser { get; set; }

        // Style properties
        public virtual bool Italic { get; set; }
        public virtual bool Bold { get; set; }
        public virtual int Size { get; set; }
        public virtual string ForegroundColor { get; set; }
        public virtual string BackgroundColor { get; set; }

        #endregion


        #region Constructors

        /// <summary>
        /// Empty parameter constructor needed by NHibernate
        /// </summary>
        public Date()
        {
            VisibilityParser = true;
            Size = 14;
            Bold = true;
            Content = DateTime.Now;
            ForegroundColor = "";
            BackgroundColor = "";
        }

        public Date(DateTime content, Container container) : this()
        {
            Content = content;
            Container = container;
        }

        #endregion


        #region Methods

        public override string ToString()
        {
            return Content.ToString();
        }

        /// <summary>
        /// Create a copy of the object with the same properties but Id - NHibernate handles it properly and VisibilityParser which is true
        /// </summary>
        /// <returns></returns>
        public virtual IElement Copy()
        {
            Date copy = new Date();

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