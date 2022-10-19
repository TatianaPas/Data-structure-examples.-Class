﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedForm
{
    public class Room
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Floor { get; set; }
        public string Size { get; set; }
        public string View { get; set; }
        public override string ToString()
        {
            return Name+", "+Floor +", "+Size+", "+View;
        }
    }
}
