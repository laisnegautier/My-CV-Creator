using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Each parser or converter of a resume should implement this
    /// </summary>
    public interface IParser
    {
        string DocumentName { get; set; }

        bool Parse();
    }
}