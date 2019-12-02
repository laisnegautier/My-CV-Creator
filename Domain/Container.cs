using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Container : IDraggable
    {
        #region Properties

        public virtual int Id { get; set; }
        public virtual int Name { get; set; }
        public virtual Resume Resume { get; set; }
        public virtual int Position { get; set; } // position in the resume

        // Style properties
        public virtual string BackgroundColor { get; set; }
        public virtual string BorderColor { get; set; } // null means no border
        public bool IsDraggable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSelected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        #endregion


        #region Constructors

        public Container()
        {
            // empty
        }

        #endregion


        #region Methods

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}