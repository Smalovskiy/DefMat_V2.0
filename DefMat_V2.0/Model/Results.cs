﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefMat_V2._0.Model
{
    class Results
    {
        public int ResultsId { get; set; }

        public double Speed { get; set; }

        public double Effort { get; set; }

        public virtual ICollection<Extension> Extensions { get; set; }
        public virtual ICollection<Materials> Materials { get; set; }

    }
}
