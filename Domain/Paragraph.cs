using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Paragraph : Text
    {
        #region Properties from Text
        public override int Id { get; set; }

        // Location properties
        public override int Position { get; set; } // index of his position in his parent-container

        // Style properties
        public override string BackgroundColor { get; set; } // Hexadecimal coding "#000FF"
        public override string ForegroundColor { get; set; }
        public override string Font { get; set; }
        public override int Size { get; set; }
        public override bool Bold { get; set; }
        public override bool Italic { get; set; }
        public override bool Underlined { get; set; }
        #endregion

        public Paragraph()
        {
            throw new System.NotImplementedException();
        }

        #region Methods
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}