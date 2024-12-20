using System;
using common;

namespace ConsoleApp2
{
    enum Grades
    {
        //Labels
        A,B,C,D,F
      //0+V,1,2,3,4
    }
    enum Gender
    {
        Male=1,Female=2,M=1,F=2
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What is Access Modifires
            //TypeA t = new TypeA();
            ////t.x = 10; Invalid Private
            ////t.y = 10; Invalid Protected
            //t.z = 10;

            #endregion
            #region Enum
            //Grades grades = Grades.A;
            //if (grades == Grades.A)
            //{
            //    Console.WriteLine("Congratulation A+");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry Not A+");
            //}
            #endregion
            #region Struct
            //Point p1 = new Point(0,4);
            ////new just from constructor selection
            ////Will Allocate 8 Bytes
            //Point p2 = p1;
            //p1.x = 1000;
            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.GetHashCode());
            #endregion
            #region What is OOP

            #endregion
            #region Encapsulation
            Employee emp = new Employee(10, "ahmad", 2000);
            Console.WriteLine(emp);
            #endregion
        }
    }
}
