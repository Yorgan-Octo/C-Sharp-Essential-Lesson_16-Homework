using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main()
        {


            House house = new House(4,5);


            House houseClone = house.DeepClone() as House;

            House houseCloneNotDeep = house.Clone();

            Console.WriteLine(house.Room1);
            Console.WriteLine(house.Room2);
            Console.WriteLine("--------------------");
            Console.WriteLine(houseClone.Room1);
            Console.WriteLine(houseClone.Room2);
            Console.WriteLine("--------------------");
            Console.WriteLine(houseCloneNotDeep.Room1);
            Console.WriteLine(houseCloneNotDeep.Room2);
            Console.WriteLine("--------------------");

            house.Room1 = 12;
            house.Room2 = 16;


            Console.WriteLine(house.Room1);
            Console.WriteLine(house.Room2);
            Console.WriteLine("--------------------");
            Console.WriteLine(houseClone.Room1);
            Console.WriteLine(houseClone.Room2);
            Console.WriteLine("--------------------");
            Console.WriteLine(houseCloneNotDeep.Room1);
            Console.WriteLine(houseCloneNotDeep.Room2);



            Console.ReadKey();
        }
    }
}
