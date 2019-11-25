using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ResumeRepository : Repository, IResumeRepository
    {
        public List<Resume> GetAll()
        {
            return Session.Query<Resume>().ToList();
        }
    }
}
