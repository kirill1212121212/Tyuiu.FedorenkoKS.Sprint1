﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FedorenkoKS.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {

            double res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return (int)res;
        }
    }
}
