﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 4)
                switch (i)
                {

                    case 0:

                    case 1:

                    case 2:
                        i++; 
                        break;
                    case 3:
                        i++;
                        Console.WriteLine(i);
                        break;
                    case 4:
                        i = i + 2;
                        Console.WriteLine(i);
                        break;
                    
                }
        }
    }
}
