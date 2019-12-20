using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public interface IDraggable : ISelectable
    {
        bool IsDraggable { get; set; }
    }
}