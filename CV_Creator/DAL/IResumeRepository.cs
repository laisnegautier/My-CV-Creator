using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IResumeRepository
    {
        void GetAll();
        void Create(Resume resume);
        void Delete(Resume resume);
        Resume Copy(Resume resume);
        void Save(Resume resume);
    }
}