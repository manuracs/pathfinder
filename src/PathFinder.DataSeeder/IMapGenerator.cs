﻿using PathFinder.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder.DataSeeder
{
    public interface IMapGenerator
    {
        Map SeedMap();
    }
}
