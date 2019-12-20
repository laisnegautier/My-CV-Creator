using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    /// <summary>
    /// A resume is composed of containers. A container is used to categorize the elements within.
    /// </summary>
    public class Container
    {
        #region Properties

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual bool Favorite { get; set; }
        public virtual string FavoriteName { get; set; }
        public virtual bool VisibilityParser { get; set; }

        // Style properties
        public virtual string BackgroundColor { get; set; }
        public virtual string BorderColor { get; set; }

        // Mapping
        public virtual IList<IElement> Elements { get; set; }
        public virtual Resume Resume { get; set; }

        #endregion


        #region Constructors

        /// <summary>
        /// Empty parameter constructor needed by NHibernate
        /// </summary>
        public Container() 
        {
            VisibilityParser = true;
            FavoriteName = "";
            BackgroundColor = "";
            BorderColor = "";
            Elements = new List<IElement>();
        }

        public Container(string name) : this()
        {
            Name = name;
        }

        public Container(string name, Resume resume) : this(name)
        {
            Name = name;
            Resume = resume;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Used for testing : discribe the properties of the container and all the elements in it
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string content = "";

            content += "#--------- PROPERTIES --------# ";
            content += "Id: " + Id + "\n Name: " + Name + "\n Favorite:" ;
            content += Favorite ? "True" : "False";
            content += "\n Favorite name: " + FavoriteName + "\n Visibility for parser: ";
            content += VisibilityParser ? "True" : "False";
            content += "\n Background color: " + BackgroundColor + "\n Border color: " + BorderColor;

            if (Elements.Count > 0)
                foreach (IElement e in Elements)
                    content += "\t Element " + e.GetType().ToString() + ": " + e.ToString() + "\n";

            return content;
        }

        /// <summary>
        /// Create a copy of the object with the same properties but Id - NHibernate handles it properly and VisibilityParser which is true
        /// </summary>
        /// <returns></returns>
        public virtual Container Copy()
        {
            Container copy = new Container();
            
            copy.Name = Name;
            copy.Favorite = Favorite;
            copy.FavoriteName = FavoriteName;
            copy.BackgroundColor = BackgroundColor;
            copy.BorderColor = BorderColor;
            copy.Resume = Resume;

            if (Elements != null)
                foreach (IElement e in Elements)
                {
                    IElement elemCopy = e.Copy();
                    elemCopy.Container = copy;
                    copy.Elements.Add(elemCopy);
                }
            return copy;
        }

        #endregion
    }
}