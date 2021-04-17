using System;
using System.Collections.Generic;

namespace StructEnumOperatorTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Struct

            //Person person = new Person();
            //person.Name = "Faiq";
            //person.Surname = "Abdullayev";
            //person.Age = 21;

            //Person person1 = new Person("Nihat", "Osmanov");

            //Person person2 = person;

            //person2.Name = "Abdulaziz";
            //Console.WriteLine(person.Name);
            //Console.WriteLine(person2.Name);

            //var list = new List<Person>();
            //list.Add(person);
            //list.Add(person1);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion

            #region Enum

            //WeekDay weekDay = WeekDay.Monday;
            ////int a = 1;
            //switch (weekDay)
            //{
            //    case WeekDay.Monday:
            //        Console.WriteLine("Monday");
            //        break;
            //    case WeekDay.Tuesday:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case WeekDay.Wednesday:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    default:
            //        break;
            //}

            //foreach (WeekDay item in Enum.GetValues(typeof(WeekDay)))
            //{
            //    Console.WriteLine((int)item);   
            //}

            #endregion

            #region Operators in custom type

            //var point1 = new Point(1, 2, 3);
            //var point2 = new Point(4, 5, 6, 7);

            //Console.WriteLine(point2 - point1);

            #endregion

            #region Tuple

            #region Tuple - reference

            //Tuple<int, string, string, int, double, int, string, Tuple<int, int>> tuple = new Tuple<int, string, string, int, double, int, string, Tuple<int, int>>(1, "Test", "TestTest", 1, 1, 5, "", new Tuple<int, int>(1, 2));
            //var tuple2 = Tuple.Create(2, "Test2", "TestTest2");

            //Console.WriteLine(tuple.Rest.Item1);
            //Console.WriteLine(tuple.Item2);
            //Console.WriteLine(tuple.Item3);

            #endregion

            #region ValueTuple

            //var valueTuple = (x: 1, y: 2);
            //Console.WriteLine(valueTuple.x);

            //(string name, string surname) person = GetPerson();
            //Console.WriteLine(person.name);

            SetPerson(("Test", "TestTest"));

            #endregion

            #endregion
        }

        #region Struct

        interface ITest
        {

        }

        struct Person : ITest
        {
            private readonly int a;

            public string Name { get; set; }

            public string Surname { get; set; }
            public int Age;

            public Person(string name, string surname)
            {
                Name = name;
                Surname = surname;
                Age = 20;

                a = 10;
            }
        }

        #endregion

        #region Enum

        enum Error
        {
            NotFound = 404,
            ServerError = 500
        }

        enum WeekDay
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }

        #endregion

        #region Operators in custom type

        class Point
        {
            public Point(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public Point(double x, double y, double z, double m)
            {
                X = x;
                Y = y;
                Z = z;
                M = m;
            }

            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
            public double M { get; set; }

            public static double operator +(Point point1, Point point2)
            {
                return point1.X + point2.X;
            }

            public static double operator -(Point point1, Point point2)
            {
                return point1.M - point2.M;
            }

            public static bool operator >(Point point1, Point point2)
            {
                return point1.Y > point2.Y;
            }

            public static bool operator <(Point point1, Point point2)
            {
                return point1.Y < point2.Y;
            }
        }

        #endregion

        #region Tuple

        private static (string, string) GetPerson()
        {
            return ("Test", "TestTest");
        }

        private static void SetPerson((string name, string surname) valueTuple)
        {
            Console.WriteLine(valueTuple.name);
            Console.WriteLine(valueTuple.surname);
        }

        #endregion
    }
}
