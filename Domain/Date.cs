﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
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
        /// Constructeur sans paramètre nécesessaire pour NHibernate
        /// </summary>
        public Date()
        {
            VisibilityParser = true;
        }

        #endregion


        #region Methods

        public override string ToString()
        {
            return Content.ToString();
        }

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

        #endregion
    }
}