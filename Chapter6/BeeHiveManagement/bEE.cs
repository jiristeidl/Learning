﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagement
{
    class Bee
    {
        const double HoneyUnitsConsumedPerMg=0.25;
        public double WeightMg { get; private set; }
        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }
        virtual public double HoneyConsumtionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }
    }
}
