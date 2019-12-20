﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public interface IElement
    {
        int Id { get; set; }
        bool VisibilityParser { get; set; }
        Container Container { get; set; }

        IElement Copy();
        string StylingCSS();
    }
}