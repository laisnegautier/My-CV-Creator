using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class H2 : IText
    {
        #region Properties
        public virtual int Id { get; set; }
        public virtual Container Container { get; set; }
        public virtual string Content { get; set; }

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
        public H2() { }

        #endregion


        #region Methods

        public override string ToString()
        {
            return Content;
        }

        #endregion
    }
}