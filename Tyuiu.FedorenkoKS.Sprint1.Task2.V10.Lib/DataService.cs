﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.FedorenkoKS.Sprint1.Task2.V10.Lib
{
    public class DataService : ISprint1Task2V10
    {
        public double ConvertMetreToInchs(int value)
        {
            return 39.37008*value;
        }
    }
}
