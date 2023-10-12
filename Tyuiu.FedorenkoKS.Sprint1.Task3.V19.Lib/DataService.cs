﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FedorenkoKS.Sprint1.Task3.V19.Lib
{
    public class DataService : ISprint1Task3V19
    {
        public bool ElephCanMove(double x1, double x2, double y1, double y2)
        {
            if (Math.Abs(x2 - x1) == Math.Abs(y2 - y1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
