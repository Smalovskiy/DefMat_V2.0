﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefMat_V2._0.Model
{
    class Materials
    {
        public int  Id { get; set; }

        public string Material { get; set; }

        public double Density { get; set; }

        public double Thicksness { get; set; }

        public virtual ICollection<Results> Results { get; set; }
    }
}