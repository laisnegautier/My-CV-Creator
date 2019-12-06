using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Line : IElement
    {
        #region Properties
        public virtual int Id { get; set; }
        public virtual Container Container { get; set; }

        // Style propertie
        public virtual string Color { get; set; }

        #endregion


        #region Constructors

        /// <summary>
        /// Constructeur sans paramètre nécesessaire pour NHibernate
        /// </summary>
        public Line() { }
    }
}