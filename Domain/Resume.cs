using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Main object of the project. A resume is used to describe the professionnal life events of someone
    /// </summary>
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
        /// Empty parameter constructor needed by NHibernate
        /// </summary>
        public Resume() 
        {
            Containers = new List<Container>();
        }

        public Resume(string title) : this()
        {
            Title = title;
        }

        #endregion


        #region Methods
        
        /// <summary>
        /// Create a copy of the resume by copying some of its properties (what is copied depends on Container and IElement classes)
        /// </summary>
        /// <returns></returns>
        public virtual Resume Copy()
        {
            Resume copy = new Resume();

            copy.Title = Title;
            copy.Save = Save;
            copy.Favorite = Favorite;
            copy.Creation = Creation;
            copy.LastUpdate = LastUpdate;

            if (Containers.Count > 0)
                foreach (Container c in Containers)
                    copy.Containers.Add(c.Copy());

            return copy;
        }

        #endregion
    }
}