﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    class Sailboat : Boat
    {
        public override string move()
        {
            return "hoist sail";
        }
    }
}
