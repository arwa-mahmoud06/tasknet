// See https://aka.ms/new-console-template for more information
//#region problem1
//using System;

//class Car
//{
//    public int Id { get; set; }
//    public string Brand { get; set; }
//    public double Price { get; set; }

//    // 1. Default constructor
//    public Car()
//    {
//    }

//    // 2. Constructor with Id
//    public Car(int id)
//    {
//        Id = id;
//    }

//    // 3. Constructor with Id and Brand
//    public Car(int id, string brand)
//    {
//        Id = id;
//        Brand = brand;
//    }

//    // 4. Constructor with Id, Brand, and Price
//    public Car(int id, string brand, double price)
//    {
//        Id = id;
//        Brand = brand;
//        Price = price;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Car car1 = new Car();

//        Car car2 = new Car(1);

//        Car car3 = new Car(2, "BMW");

//        Car car4 = new Car(3, "Mercedes", 500000);

//        Console.WriteLine(car4.Id);
//        Console.WriteLine(car4.Brand);
//        Console.WriteLine(car4.Price);
//    }
//} 
//#endregion
//-----------------------------------------------------------------------------------------------
//#region problem2
//using System;

//class Calculator
//{
//    // Add two integers
//    public int Sum(int x, int y)
//    {
//        return x + y;
//    }

//    // Add three integers
//    public int Sum(int x, int y, int z)
//    {
//        return x + y + z;
//    }

//    // Add two doubles
//    public double Sum(double x, double y)
//    {
//        return x + y;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Calculator calculator = new Calculator();

//        Console.WriteLine(calculator.Sum(10, 20));

//        Console.WriteLine(calculator.Sum(10, 20, 30));

//        Console.WriteLine(calculator.Sum(10.5, 20.5));
//    }
//} 
//#endregion
//-------------------------------------------------------------------------------------
//#region problem3
//using System;

//class Parent
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Parent(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }
//}

//class Child : Parent
//{
//    public int Z { get; set; }

//    public Child(int x, int y, int z) : base(x, y)
//    {
//        Z = z;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Child child = new Child(10, 20, 30);

//        Console.WriteLine(child.X);
//        Console.WriteLine(child.Y);
//        Console.WriteLine(child.Z);
//    }
//} 
//#endregion
//------------------------------------------------------------------------
//#region problem4
//using System;

//class Parent
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Parent(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public int Product()
//    {
//        return X * Y;
//    }
//}

//class Child : Parent
//{
//    public int Z { get; set; }

//    public Child(int x, int y, int z) : base(x, y)
//    {
//        Z = z;
//    }

//    // Using new
//    public new int Product()
//    {
//        return X * Y * Z;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Child child = new Child(2, 3, 4);

//        Console.WriteLine(child.Product());

//        Parent parent = child;

//        Console.WriteLine(parent.Product());
//    }
//} 
//#endregion
//---------------------------------------------------------------------------------------------
//#region problem4override
//class Parent
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Parent(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public virtual int Product()
//    {
//        return X * Y;
//    }
//}

//class Child : Parent
//{
//    public int Z { get; set; }

//    public Child(int x, int y, int z) : base(x, y)
//    {
//        Z = z;
//    }

//    public override int Product()
//    {
//        return X * Y * Z;
//    }
//} 
//#endregion
//------------------------------
//#region problem5
//using System;

//class Parent
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Parent(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }
//}

//class Child : Parent
//{
//    public int Z { get; set; }

//    public Child(int x, int y, int z) : base(x, y)
//    {
//        Z = z;
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y}, {Z})";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Parent parent = new Parent(10, 20);

//        Child child = new Child(10, 20, 30);

//        Console.WriteLine(parent);
//        Console.WriteLine(child);
//    }
//} 
//#endregion
//-----------------------------------------------------------
//#region problem6
//class Circle : IShape
//{
//    public double Radius { get; set; }

//    public double Area
//    {
//        get
//        {
//            return Math.PI * Radius * Radius;
//        }
//    }

//    public void Draw()
//    {
//        Console.WriteLine("Drawing Circle");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Circle circle = new Circle();

//        circle.Radius = 5;

//        Console.WriteLine(circle.Area);

//        circle.Draw();
//    }
//} 
//#endregion
//-----------------------------------------------
//#region problem6 rectangle
//using System;

//interface IShape
//{
//    double Area { get; }

//    void Draw();
//}

//class Rectangle : IShape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public double Area
//    {
//        get
//        {
//            return Width * Height;
//        }
//    }

//    public void Draw()
//    {
//        Console.WriteLine("Drawing Rectangle");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Rectangle rectangle = new Rectangle();

//        rectangle.Width = 5;
//        rectangle.Height = 4;

//        Console.WriteLine("Area = " + rectangle.Area);

//        rectangle.Draw();
//    }
//} 
//#endregion
//---------------------------
//#region problem7
//using System;

//interface IShape
//{
//    double Area { get; }

//    void Draw();

//    // Default implementation
//    void PrintDetails()
//    {
//        Console.WriteLine("This is a Shape");
//    }
//}

//class Circle : IShape
//{
//    public double Radius { get; set; }

//    public double Area
//    {
//        get
//        {
//            return Math.PI * Radius * Radius;
//        }
//    }

//    public void Draw()
//    {
//        Console.WriteLine("Drawing Circle");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Circle circle = new Circle();

//        circle.Radius = 5;

//        Console.WriteLine("Area = " + circle.Area);

//        circle.Draw();

//        IShape shape = circle;
//        shape.PrintDetails();
//    }
//} 
//#endregion
//----------------------------------------
//#region problem8
//using System;

//interface IMovable
//{
//    void Move();
//}

//class Car : IMovable
//{
//    public void Move()
//    {
//        Console.WriteLine("Car is moving");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        IMovable movable = new Car();

//        movable.Move();
//    }
//} 
//#endregion
//---------------------
//#region problem9
//using System;

//interface IReadable
//{
//    void Read();
//}

//interface IWritable
//{
//    void Write();
//}

//class File : IReadable, IWritable
//{
//    public void Read()
//    {
//        Console.WriteLine("Reading File");
//    }

//    public void Write()
//    {
//        Console.WriteLine("Writing File");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        File file = new File();

//        file.Read();
//        file.Write();
//    }
//} 
//#endregion
//-------------------------------
using System;

abstract class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing Shape");
    }

    public abstract double CalculateArea();
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle();

        rectangle.Width = 5;
        rectangle.Height = 4;

        rectangle.Draw();

        Console.WriteLine("Area = " + rectangle.CalculateArea());
    }
}