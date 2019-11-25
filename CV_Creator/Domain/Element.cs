using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public abstract class Element : IDraggable
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