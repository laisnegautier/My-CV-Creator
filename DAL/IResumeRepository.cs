using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IResumeRepository
    {
        List<Resume> GetAll();
        Resume GetById(int id);
        List<Resume> GetTheLastFive();
        List<Resume> GetTheFavoriteOnes();

        void Save(Resume resume);

        //void Delete(Resume resume);
        //Resume Copy(Resume resume);
    }
}