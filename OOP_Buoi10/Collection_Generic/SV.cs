﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collection_Generic
{
    internal class SV
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public SV(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        
    }
}
