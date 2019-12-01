using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public class ParagraphRepository : Repository, IParagraphRepository
    {
        public List<Paragraph> GetAll()
        {
            return Session.Query<Paragraph>().ToList();
        }
    }
}