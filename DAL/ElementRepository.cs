using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public class ElementRepository : Repository, IElementRepository
    {
        public IElement GetById(int id)
        {
            return Session.Get<IElement>(id);
        }

        public void Delete(IElement element)
        {
            Session.Delete(element);
            Session.Flush();
        }
    }
}