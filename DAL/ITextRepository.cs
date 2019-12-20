using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface ITextRepository
    {
        void GetAll();
        void UpdatePosition(Text text);
        void Delete(Text text);
    }
}