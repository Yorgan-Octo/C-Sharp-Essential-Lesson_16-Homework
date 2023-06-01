using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {

            Block block1 = new Block(2, 2, 4, 4);
            Block block2 = new Block(2, 2, 2, 2);
            Block block3 = new Block(6, 7, 8, 3);
            Block block4 = new Block(6, 7, 8, 3);

            Console.WriteLine(new String('=', 50));

            Console.WriteLine("Порівняння:");
            Console.WriteLine(new String('=', 50));

            Console.WriteLine($"block1 == block2: {block1.Equals(block2)}");
            Console.WriteLine($"block2 == block3: {block2.Equals(block3)}");
            Console.WriteLine($"block3 == block4: {block3.Equals(block4)}");
            Console.WriteLine($"block4 == block1: {block4.Equals(block1)}");

            Console.WriteLine();
            Console.WriteLine(new String('=',50));

            Console.WriteLine("Інформація про блоки:");
            Console.WriteLine(new String('=', 50));
            Console.WriteLine("block1:");
            Console.WriteLine(block1.ToString());
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("block2:");
            Console.WriteLine(block2.ToString());
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("block3:");
            Console.WriteLine(block3.ToString());
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("block4:");
            Console.WriteLine(block4.ToString());


            Console.ReadKey();
        }
    }
}
