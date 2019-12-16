using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public class ResumeRepository : Repository, IResumeRepository
    {
        public List<Resume> GetAll()
        {
            return Session.Query<Resume>().ToList();
        }

        public Resume GetById(int id)
        {
            return Session.Get<Resume>(id);
        }

        public List<Resume> GetTheLastFive()
        {
            return Session.Query<Resume>()
                .OrderByDescending(x => x.LastUpdate)
                .Take(5)
                .ToList();
        }

        public List<Resume> GetTheFavoriteOnes()
        {
            return Session.Query<Resume>()
                .OrderByDescending(x => x.LastUpdate)
                .Where(x => (x.Favorite == true))
                .ToList();
        }

        /// <summary>
        /// Saving a resume, i.e. insert or update it in the DB.
        /// NB : it does it in cascade, so every containers and elements in it are inserted/updated too
        /// </summary>
        /// <param name="resume"></param>
        public void Save(Resume resume)
        {
            // In case of an update or insert that fails : it avoids to declare the Resume as saved when it may be not
            try
            {
                // This allows to build the creation date when insert and not override it when updating
                if (resume.Id == default(int)) resume.Creation = DateTime.Now;

                resume.LastUpdate = DateTime.Now;

                // The object is indeed being saved/updated
                resume.Save = true;

                Session.SaveOrUpdate(resume);
                Session.Flush();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Delete(Resume resume)
        {
            Session.Delete(resume);
            Session.Flush();
        }
    }
}