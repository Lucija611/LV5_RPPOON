﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_L
{
    public interface IBillable
    {
        double Price { get; }
        string Description(int depth = 0);
    }
}
