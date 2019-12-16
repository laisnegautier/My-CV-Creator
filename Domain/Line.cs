using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Line element similar to an horizontal line and acts as a separator between other elements
    /// </summary>
    public class Line : IElement
    {
        #region Properties
        public virtual int Id { get; set; }
        public virtual Container Container { get; set; }
        public virtual bool VisibilityParser { get; set; }

        // Style properties
        public virtual string Color { get; set; }

        #endregion


        #region Constructors

        /// <summary>
        /// Empty parameter constructor needed by NHibernate
        /// </summary>
        public Line()
        {
            VisibilityParser = true;
            Color = "#00000";
        }

        public Line(Container container) : this()
        {
            Container = container;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Create a copy of the object with the same properties but Id - NHibernate handles it properly and VisibilityParser which is true
        /// </summary>
        /// <returns></returns>
        public virtual IElement Copy()
        {
            Line copy = new Line();

            copy.Container = Container;
            copy.Color = Color;

            return copy;
        }

        #endregion
    }
}