using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Separator : IDragAndDroppable
    {
        #region Properties

        public virtual Container Container { get; set; }

        #endregion


        #region Constructors

        public Separator()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}