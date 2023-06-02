using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main()
        {

            DateRefuge correntData = new DateRefuge("11/12/2022");

            DateRefuge newData = new DateRefuge("11/12/2022");

            Console.WriteLine(correntData.MyDate);

            correntData = correntData + 12;

            Console.WriteLine(correntData.MyDate);


            int relase = correntData - newData;


            Console.WriteLine($"Кількість днів між датами: {relase}");

            Console.ReadKey();
        }
    }
}
