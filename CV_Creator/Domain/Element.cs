using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public abstract class Element : IDragAndDroppable
    {
        public virtual Container Container
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}