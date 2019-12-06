using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public interface IText : IElement
    {
        bool Italic { get; set; }
        bool Bold { get; set; }
        int Size { get; set; } // In pixels
        string ForegroundColor { get; set; } // Hexadecimal
        string BackgroundColor { get; set; } // Hexadecimal
    }
}