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

        // Mapping
        public virtual IList<IElement> Elements { get; set; }
        public virtual Resume Resume { get; set; }

        #endregion


        #region Constructors

        /// <summary>
        /// Constructeur sans paramètre nécesessaire pour NHibernate
        /// </summary>
        public Container()
        {
            Elements = new List<IElement>();
        }

        #endregion


        #region Methods

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public virtual Container Copy()
        {
            Container copy = new Container();

            copy.Name = Name;
            copy.Favorite = Favorite;
            copy.FavoriteName = FavoriteName;
            copy.BackgroundColor = BackgroundColor;
            copy.BorderColor = BorderColor;
            copy.Resume = Resume;

            if(Elements != null)
            {
                copy.Elements = new List<IElement>();
                foreach (IElement e in Elements)
                    copy.Elements.Add(e.Copy());
            }
            return copy;
        }

        #endregion
    }
}