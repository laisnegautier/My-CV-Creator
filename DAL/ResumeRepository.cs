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

        public void Save(Resume resume)
        {
            // In case of an update or insert that fails : it avoids to declare the Resume as saved when it may be not
            try
            {
                // This allows to build the creation date when insert and not override it when updating
                if (resume.Id == default) resume.Creation = DateTime.Now;

                resume.LastUpdate = DateTime.Now;

                // The object is indeed being saved/updated
                resume.Save = true;

                Session.SaveOrUpdate(resume);
                Session.Flush();
            }
            catch(Exception e)
            {
                throw new Exception();
            }
        }
    }
}