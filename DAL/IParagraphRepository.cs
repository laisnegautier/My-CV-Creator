﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public interface IParagraphRepository
    {
        List<Paragraph> GetAll();
        Paragraph GetById(int id);
    }
}