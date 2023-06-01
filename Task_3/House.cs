using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{

    class A 
    {
        public int a = 5;
    }

    class B
    {
        public int b = 3;
    }


    internal class House
    {

        private A room1 = new A();
        private B room2 = new B();


        public int Room1 { get { return room1.a; } set { room1.a = value; } }
        public int Room2 { get { return room2.b; } set { room2.b = value; } }

        public House(int room1, int room2)
        {
            Room1 = room1;
            Room2 = room2;
        }

        public House DeepClone()
        {
            return new House(this.Room1, this.Room2);
        }


        public House Clone()
        {
            House clone = this.MemberwiseClone() as House;

            return clone;
        }


    }
}
