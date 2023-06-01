using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Block
    {

        protected int right, left, up, down;


        public Block(int right, int left, int up, int down)
        {
            this.right = right;
            this.left = left;
            this.up = up;
            this.down = down;
        }


        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Block b = (Block)obj;

            return right == b.right && left == b.left && up == b.up && down == b.down;

        }


        public override string ToString()
        {
            return $"Права сторона = {right} см\nЛіва сторона = {left} см\nВерзня сторона = {up} см\nНижня сторона = {down} см";
        }


    }
}
