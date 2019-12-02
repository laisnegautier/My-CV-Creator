using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Paragraph : Element
    {
        #region Properties
        // Id en abstract pour le moment
        public virtual string Content { get; set; }

        #endregion


        #region Constructors

        public Paragraph()
        {
            // empty
        }

        #endregion


        #region Methods

        public override string ToString()
        {
            return Content;
        }

        #endregion
    }
}