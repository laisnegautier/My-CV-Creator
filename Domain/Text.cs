using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public abstract class Text : Element
    {
        public abstract int Id { get; set; }

        // Location properties
        public abstract int Position { get; set; } // index of his position in his parent-container

        // Style properties
        public abstract string BackgroundColor { get; set; } // Hexadecimal coding "#000FF"
        public abstract string ForegroundColor { get; set; }
        public abstract string Font { get; set; }
        public abstract int Size { get; set; }
        public abstract bool Bold { get; set; }
        public abstract bool Italic { get; set; }
        public abstract bool Underlined { get; set; }
    }
}