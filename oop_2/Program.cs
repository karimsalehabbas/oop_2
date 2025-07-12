using System;

namespace oop_2
{

    #region Question Structs
    #region Struct Question 1
    //internal struct Person
    //{
    //    public string Name;
    //    public int Age;
    //
    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}
    #endregion 

    #region Struct Question 2
    //internal struct Point
    //{
    //    public double X;
    //    public double Y;
    //
    //    public Point(double x, double y)
    //    {
    //        X = x;
    //        Y = y;
    //    }
    //}


    #endregion

    #region Struct Question 3
    //internal struct Person
    //{
    //    public string Name;
    //    public int Age;
    //
    //    public Person (string name , int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}
    #endregion

    #region Struct Question 4
    //internal struct Rectangle
    //{
    //    private double width;
    //    private double height;
    //
    //    public double Width
    //    {
    //        get { return width; }
    //        set
    //        {
    //            if (width >= 0)
    //                width = value;
    //            else
    //                Console.WriteLine("Error : Width Cannot Be Negative");
    //        }
    //    }
    //    public double Height
    //    {
    //        get { return height; }
    //        set
    //        {
    //            if (height >= 0)
    //                height = value;
    //            else
    //                Console.WriteLine("Error : Hight Cannot Be Negative");
    //        }
    //    }
    //    public double Area => width * height;
    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"Rectangle Dimensions: Width = {Width}, Height = {Height}");
    //        Console.WriteLine($"Area : {Area}");
    //    }
    //}
    #endregion
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Person[] people = new Person[3];
            //people[0] = new Person("Hassan", 20);
            //people[1] = new Person("Mohamed", 24);
            //people[2] = new Person("Ahmed", 16);
            //Console.WriteLine("Person Details : ");
            //
            //foreach (Person person in people)
            //{
            //    Console.WriteLine($"Name : {person.Name}, Age: {person.Age}");
            //}
            #endregion

            #region Question 2
            //Console.WriteLine("Enter Coordinates For Point 1 : ");
            //Console.WriteLine("X1 : ");
            //double X1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Y1 : ");
            //double Y1 = Convert.ToDouble(Console.ReadLine());   
            //Point P1 = new Point(X1, Y1);
            //
            //Console.WriteLine("Enter Coordinates For Point 2 : ");
            //Console.WriteLine("X2 : ");
            //double X2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Y2 : ");
            //double Y2 = Convert.ToDouble(Console.ReadLine());
            //Point P2 = new Point(X2, Y2);
            //
            //double Distance = Math.Sqrt(Math.Pow(P2.X - P1.X, 2) + Math.Pow(P2.Y - P1.Y, 2));
            //Console.WriteLine($"The Distance Between The Two Points  = {Distance}");
            #endregion

            #region Question 3
            //Person[] people = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter Your Details For Person {i + 1} : ");
            //    Console.WriteLine("Name : ");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Age : ");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    people[i] = new Person (name, age);
            //    Console.WriteLine();
            //}
            //
            //Person Oldest = people[0];
            //for (int i = 1; i < people.Length; i++)
            //{
            //    if (people[i].Age > Oldest.Age)
            //    {
            //        Oldest = people[i];
            //    }
            //}
            //
            //Console.WriteLine($"The Oldest Person Is : {Oldest.Name} , With Age = {Oldest.Age}");
            #endregion

            #region Question 4
            //Rectangle rectangle = new Rectangle();
            //rectangle.Width = 15;
            //rectangle.Height = 13.5;
            //
            //rectangle.DisplayInfo();
            #endregion        }
        }
    }
    }
