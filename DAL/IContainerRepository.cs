using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IContainerRepository
    {
        List<Container> GetFavoriteOnes();
        void Delete(Container container);
    }
}