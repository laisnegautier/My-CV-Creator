using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public class ParagraphRepository : Repository, IElementRepository
    {
        public Element GetById(int id)
        {
            return Session.Get<Paragraph>(id);
        }

        public void Delete(Element paragraph)
        {
            paragraph = (Paragraph)paragraph;

            Session.Delete(paragraph);
            Session.Flush();
        }
    }
}