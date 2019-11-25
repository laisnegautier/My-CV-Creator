using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IContainerRepository
    {
        List<Container> GetAll();
        //void Delete(Container container);
        //void UpdatePosition(Container container);
    }
}