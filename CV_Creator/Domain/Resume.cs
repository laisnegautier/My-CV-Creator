using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Resume
    {
        #region Properties

        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual bool Save { get; set; } // To check if the current resume is saved before quitting the form
        public virtual bool Favorite { get; set; }
        public virtual String LastModification { get; set; }
        public virtual List<Container> Containers { get; set; }

        #endregion


        #region Constructors

        public Resume()
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