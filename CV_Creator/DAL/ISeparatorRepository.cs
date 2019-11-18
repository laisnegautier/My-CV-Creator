using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface ISeparatorRepository
    {
        void GetAll();
        void UpdatePosition(Separator separator);
        void Delete(Separator separator);
    }
}