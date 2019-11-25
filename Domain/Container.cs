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

        // Style properties
        public virtual string BackgroundColor { get; set; }
        public virtual string BorderColor { get; set; }

        #endregion


        #region Constructors

        public Container()
        {
            // empty
        }

        #endregion


        #region Methods

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}