using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Separator : IDragAndDroppable
    {
        public virtual Container Container { get; set; }
    }
}