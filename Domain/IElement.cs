using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public interface IElement
    {
        int Id { get; set; }
        Container Container { get; set; }
    }
}