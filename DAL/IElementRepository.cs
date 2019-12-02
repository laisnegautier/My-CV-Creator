using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IElementRepository
    {
        //List<Element> GetFavoriteOnes();
        Element GetById(int id);

        void Delete(Element element);
    }
}