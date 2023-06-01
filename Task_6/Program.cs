using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main()
        {

            Point point1 = new Point(1, 1, 1);
            Point point2 = new Point(2, 2, 2);


            Point point3 = point1 + point2;


            Console.WriteLine(point3.ToString());
            
            Console.ReadKey();

        }
    }
}
