using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;
using DAL;

namespace StubRepository
{
    public class ResumeRepository : IResumeRepository
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
            List<Resume> result = new List<Resume>();
            Resume test = new Resume("CVtest1");
            Resume test2 = new Resume("CVtest2");
            result.Add(test);
            result.Add(test2);
            return result;
        }

        public void Save(Resume resume)
        {
            throw new NotImplementedException();
        }
    }
}
