using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Container
    {
        #region Properties

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual bool Favorite { get; set; }
        public virtual string FavoriteName { get; set; }

        // Style properties
        public virtual string BackgroundColor { get; set; }
        public virtual string BorderColor { get; set; }

        public virtual IList<IElement> Elements { get; set; }

        #endregion


        #region Constructors

        /// <summary>
        /// Constructeur sans paramètre nécesessaire pour NHibernate
        /// </summary>
        public Container() { }

        #endregion


        #region Methods

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}