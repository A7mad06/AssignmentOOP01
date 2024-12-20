using System.ComponentModel;
using System.Globalization;
using System.Numerics;

namespace ConsoleApp1
{
    #region Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data
    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name = {Name} , Age = {Age}";
        }
    }
    #endregion
    #region Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
    struct Point
    {
        public int X;
        public int Y;
    }
    #endregion
    #region Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person
    struct Personn
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    #endregion
    internal class Program
    {
        #region Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum
        enum WeekDays
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        #endregion
        #region Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
        enum Season
        {
            Spring, Summer, Autumn, Winter
        }
        #endregion
        #region Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
        enum Permissions
        {
            Read, Write, Delete, Execute
        }
        #endregion
        #region Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
        enum Colors
        {
            Red=1,Green=2,Blue=3,red=1,green=2,blue=3,r=1,R=1,G=2,g=2,b=3,B=3
        }
        #endregion

        static void Main(string[] args)
        {
            #region Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] persons = new Person[3];
            //persons[0].Name = "ahmad";
            //persons[0].Age = 20;
            //persons[1].Name = "mohammed";
            //persons[1].Age= 30;
            //persons[2].Name = "Ali";
            //persons[2].Age = 10;
            //foreach(Person person in persons)
            //{
            //    Console.WriteLine(person);
            //}
            #endregion
            #region Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Season season;
            //do
            //{
            //    Console.WriteLine("Enter an season");
            //} while (!Enum.TryParse(Console.ReadLine(), out season));
            //switch (season)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("march to may");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("December to February");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("june to august");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("September to November");
            //        break;
            //    default:
            //        break;
            //}
            #endregion
            #region  Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
            //Permissions File;
            //do
            //{
            //    Console.WriteLine("Enter A Permission to the File:");
            //} while (!Enum.TryParse(Console.ReadLine(), out File));
            //switch (File)
            //{
            //    case Permissions.Read:
            //        Console.WriteLine("Read");
            //        break;
            //    case Permissions.Write:
            //        Console.WriteLine("Write");
            //        break;
            //    case Permissions.Delete:
            //        Console.WriteLine("Delete");
            //        break;
            //    case Permissions.Execute:
            //        Console.WriteLine("Execute");
            //        break;
            //    default:
            //        break;
            //}
            #endregion
            #region Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Colors color;
            //Enum.TryParse(Console.ReadLine(), out color);
            //if (color == Colors.b || color == Colors.r || color == Colors.g)
            //{
            //    Console.WriteLine("Primary");
            //}
            //else
            //{
            //    Console.WriteLine("Not Primary");
            //}
            #endregion
            #region Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Point p1=new Point(), p2=new Point();
            //do
            //{
            //    Console.WriteLine("Enter X of First Point:");
            //} while (!int.TryParse(Console.ReadLine(), out p1.X));
            //do
            //{
            //    Console.WriteLine("Enter Y of First Point:");
            //} while (!int.TryParse(Console.ReadLine(), out p1.Y));
            //do
            //{
            //    Console.WriteLine("Enter X of Second Point:");
            //} while (!int.TryParse(Console.ReadLine(), out p2.X));
            //do
            //{
            //    Console.WriteLine("Enter X of Second Point:");
            //} while (!int.TryParse(Console.ReadLine(), out p2.Y));
            //Console.WriteLine($"The Distance Between p1 and p2 is {Math.Sqrt(Math.Pow(p1.X-p2.X,2)+ Math.Pow(p1.Y - p2.Y,2))}");
            #endregion
            #region Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person
            //Personn[] persons = new Personn[3];
            //int mx = 0,mxIndex=0;
            //for(int i = 0; i < 3; i++)
            //{
            //    int age = 0;
            //    Console.WriteLine($"Enter the {i+1} person Name: ");
            //    persons[i].Name = Console.ReadLine();
            //    do
            //    {
            //        Console.WriteLine($"Enter the {i+1} person Age: ");
            //    }
            //    while (!int.TryParse(Console.ReadLine(),out age) && age<=0);
            //    persons[i].Age = age;
            //    if (mx < age)
            //    {
            //        mx = age;
            //        mxIndex = i;
            //    }
            //}
            //Console.WriteLine($"The name of the oldest person is {persons[mxIndex].Name}");
            #endregion
        }
    }
}
