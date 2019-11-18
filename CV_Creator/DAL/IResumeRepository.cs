using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IResumeRepository
    {
        void Save(Resume resume);
        void GetAll();
        Resume CopyAll();
    }
}