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
        
        public virtual DateTime Creation { get; set; }
        public virtual DateTime LastUpdate { get; set; }
        public virtual IList<Container> Containers { get; set; }

        #endregion


        #region Constructors

        /// <summary>
        /// Constructeur sans paramètre nécesessaire pour NHibernate
        /// </summary>
        public Resume() { }

        public Resume(string title)
        {
            Title = title;
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