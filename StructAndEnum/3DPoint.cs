using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAndEnum
{
    class _3DPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public string str = "Alshaimaa";

        public _3DPoint() : this(1, 2, 3)
        {

        }

        public _3DPoint(int X) : this(X, 2, 3)
        {
            this.X = X;
        }

        public _3DPoint(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString()
        {
            return $"X = {X} ,Y = {Y}, Z = {Z}";
        }


        public static void Display(_3DPoint[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void ChangeCoordinates(int newX, int newY, int newZ)
        {
            this.X = newX;
            this.Y = newY;
            this.Z = newZ;
        }

        public static void displayString(string st)
        {
            st = "Hello";
            //Console.WriteLine("The string is " + st);
        }
    }
}
