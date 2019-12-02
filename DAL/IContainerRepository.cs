using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IContainerRepository
    {
        void GetAll();
        void Delete(Container container);
        void UpdatePosition(Container container);
    }
}