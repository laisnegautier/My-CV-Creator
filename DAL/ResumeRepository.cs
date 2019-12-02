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

        public void Save(Resume resume)
        {
            resume.Save = true;
            // Pour conserver la date de creation
            if (resume.Id == default) resume.Creation = DateTime.Now;
            resume.LastModification = DateTime.Now;

            resume.Save = true; // doit passer en false lors d'une modification dans le CV
            Session.SaveOrUpdate(resume);
            Session.Flush();
        }
    }
}