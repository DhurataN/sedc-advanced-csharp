﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakingG1
{
    class Program
    {
        static void Main(string[] args)
        {
            var parking = new Parking<string>(20);


            Console.WriteLine(parking);
        }
    }
}
