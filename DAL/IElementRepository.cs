﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IElementRepository
    {
        IElement GetById(int id);

        void Delete(IElement element);
    }
}