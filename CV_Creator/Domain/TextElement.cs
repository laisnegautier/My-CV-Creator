using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public abstract class TextElement : IDragAndDroppable
    {
        #region Properties

        public virtual int Id { get; set; }
        public virtual string Content { get; set; }

        // Location properties
        public virtual Container Container { get; set; }
        public virtual int Position { get; set; } // index of his position in his parent-container

        // Style properties
        public virtual string BackgroundColor { get; set; } // Hexadecimal coding "#000FF"
        public virtual string ForegroundColor { get; set; }
        public virtual string Font { get; set; }
        public virtual int Size { get; set; }
        public virtual bool Bold { get; set; }
        public virtual bool Italic { get; set; }
        public virtual bool Underlined { get; set; }

        #endregion


        #region Constructors

        public TextElement()
        {
            // empty
        }

        // Faire constructeur plein

        #endregion


        #region Methods
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}