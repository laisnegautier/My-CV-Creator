using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public class ResumeRepository : Repository, IResumeRepository
    {
        public Resume Copy(Resume resume)
        {
            throw new NotImplementedException();
        }

        public void Create(Resume resume)
        {
            throw new NotImplementedException();
        }

        public void Delete(Resume resume)
        {
            throw new NotImplementedException();
        }

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
            Session.SaveOrUpdate(resume);
            Session.Flush();
        }
    }
}