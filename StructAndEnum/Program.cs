using System;

namespace StructAndEnum
{
    [Flags]
    enum Role
    {
        Admin = 1,
        Accountant = 2,
        Stock = 4,
        Reception = 8
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Employee
            Role r1  = Role.Admin;
            Employee e = new Employee("Alshaimaa", 5000, r1);
            e.Display();


            //Add Role
            Role r2 = Role.Accountant;
            e.AssignRole(r2);
            e.Display();

            //Has Role
            Role r3 = Role.Stock;
            if(e.HasRole(r3))
                Console.WriteLine($"The employee has {r3}");
            else
                Console.WriteLine($"The employee hasn't {r3}");

            #endregion

            Console.WriteLine("\n ********************* 3DPoint ********************");

            #region 3DPoint
            _3DPoint p1 = new _3DPoint { X = 2, Y = 5, Z = 3 };
            _3DPoint p2 = new _3DPoint(2) { Y = 5 };


            if (p1 == p2)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");

            Console.WriteLine("**********************************");
            _3DPoint[] p = new _3DPoint[2];
            p[0] = p1;
            p[1] = p2;
            _3DPoint.Display(p);

            Console.WriteLine("**********************************");
            p[0].ChangeCoordinates(3, 9, 4);
            Console.WriteLine("After change " + p[0].ToString());

            #endregion

            Console.WriteLine("**********************************");
            string g = "Alshaimaa";

            _3DPoint.displayString(g);

            Console.WriteLine("The String is " + g);

        }
    }
}
