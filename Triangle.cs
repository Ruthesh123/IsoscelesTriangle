using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IsoscelesTriangle
{
    // Author: Ruthesh Reddy Adla
    public static class Triangle
    {
        public static bool IsIsosceles(int a, int b, int c)
        {
            Console.WriteLine("Method executed by: Ruthesh Reddy Adla");
            return (a == b || b == c || a == c);
        }
    }
}
