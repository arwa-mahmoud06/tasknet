// See https://aka.ms/new-console-template for more information
//#region problem1
//using System;

//interface IVehicle
//{
//    void StartEngine();
//    void StopEngine();
//}

//class Car : IVehicle
//{
//    public void StartEngine()
//    {
//        Console.WriteLine("Car engine started");
//    }

//    public void StopEngine()
//    {
//        Console.WriteLine("Car engine stopped");
//    }
//}

//class Bike : IVehicle
//{
//    public void StartEngine()
//    {
//        Console.WriteLine("Bike engine started");
//    }

//    public void StopEngine()
//    {
//        Console.WriteLine("Bike engine stopped");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        IVehicle car = new Car();
//        IVehicle bike = new Bike();

//        car.StartEngine();
//        car.StopEngine();

//        bike.StartEngine();
//        bike.StopEngine();
//    }
//} 
//#endregion
//-------------------------------------

//#region problem2

//using System;

//abstract class Shape
//{
//    public abstract double GetArea();

//    public void Display()
//    {
//        Console.WriteLine("This is a shape");
//    }
//}

//class Rectangle : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public override double GetArea()
//    {
//        return Width * Height;
//    }
//}

//class Circle : Shape
//{
//    public double Radius { get; set; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    public override double GetArea()
//    {
//        return Math.PI * Radius * Radius;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Shape rectangle = new Rectangle(5, 4);
//        Shape circle = new Circle(3);

//        rectangle.Display();
//        Console.WriteLine("Rectangle Area: " + rectangle.GetArea());

//        circle.Display();
//        Console.WriteLine("Circle Area: " + circle.GetArea());
//    }
//}

//#endregion
//----------------------------------------------
//#region problem3
//using System;

//class Product : IComparable<Product>
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Price { get; set; }

//    public Product(int id, string name, double price)
//    {
//        Id = id;
//        Name = name;
//        Price = price;
//    }

//    public int CompareTo(Product other)
//    {
//        return Price.CompareTo(other.Price);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Product[] products =
//        {
//            new Product(1, "Laptop", 30000),
//            new Product(2, "Mouse", 500),
//            new Product(3, "Keyboard", 1500)
//        };

//        Array.Sort(products);

//        foreach (Product product in products)
//        {
//            Console.WriteLine(product.Name + " - " + product.Price);
//        }
//    }
//} 
//#endregion
//--------------------------------------
//#region problem4
//using System;

//class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Grade { get; set; }

//    public Student(int id, string name, double grade)
//    {
//        Id = id;
//        Name = name;
//        Grade = grade;
//    }

//    public Student(Student student)
//    {
//        Id = student.Id;
//        Name = student.Name;
//        Grade = student.Grade;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student student1 = new Student(1, "Arwa", 90);

//        Student student2 = student1;
//        Student student3 = new Student(student1);

//        student2.Name = "Sara";
//        student3.Name = "Mariam";

//        Console.WriteLine("Original: " + student1.Name);
//        Console.WriteLine("Shallow Copy: " + student2.Name);
//        Console.WriteLine("Deep Copy: " + student3.Name);
//    }
//} 
//#endregion
//-----------------------
//#region problem5
//using System;

//interface IWalkable
//{
//    void Walk();
//}

//class Robot : IWalkable
//{
//    public void Walk()
//    {
//        Console.WriteLine("Robot walks using IWalkable");
//    }

//    void IWalkable.Walk()
//    {
//        Console.WriteLine("Explicit IWalkable Walk");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Robot robot = new Robot();

//        robot.Walk();

//        IWalkable walkable = robot;
//        walkable.Walk();
//    }
//} 
//#endregion
//-------------------
//#region problem6
//using System;

//struct Account
//{
//    private int AccountId;
//    private string AccountHolder;
//    private double Balance;

//    public int Id
//    {
//        get { return AccountId; }
//        set { AccountId = value; }
//    }

//    public string Holder
//    {
//        get { return AccountHolder; }
//        set { AccountHolder = value; }
//    }

//    public double Amount
//    {
//        get { return Balance; }
//        set { Balance = value; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Account account = new Account();

//        account.Id = 101;
//        account.Holder = "Arwa";
//        account.Amount = 5000;

//        Console.WriteLine("Account ID: " + account.Id);
//        Console.WriteLine("Account Holder: " + account.Holder);
//        Console.WriteLine("Balance: " + account.Amount);
//    }
//} 
//#endregion
//---------------------------------
//#region 
//using System;

//interface ILogger
//{
//    void Log()
//    {
//        Console.WriteLine("Default log message");
//    }
//}

//class ConsoleLogger : ILogger
//{
//    public void Log()
//    {
//        Console.WriteLine("Console log message");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ILogger logger = new ConsoleLogger();

//        logger.Log();
//    }
//} 
//#endregion
//------------------------------------
//#region problem8
//using System;

//class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }

//    public Book()
//    {
//        Title = "Unknown";
//        Author = "Unknown";
//    }

//    public Book(string title)
//    {
//        Title = title;
//        Author = "Unknown";
//    }

//    public Book(string title, string author)
//    {
//        Title = title;
//        Author = author;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Book book1 = new Book();
//        Book book2 = new Book("Harry Potter");
//        Book book3 = new Book("The Hobbit", "J.R.R. Tolkien");

//        Console.WriteLine(book1.Title + " - " + book1.Author);
//        Console.WriteLine(book2.Title + " - " + book2.Author);
//        Console.WriteLine(book3.Title + " - " + book3.Author);
//    }
//} 
//#endregion
//----------------------------
//part2
//#region problem1
//using System;

//interface IShapeSeries
//{
//    int CurrentShapeArea { get; set; }

//    void GetNextArea();

//    void ResetSeries();
//}

//class SquareSeries : IShapeSeries
//{
//    public int CurrentShapeArea { get; set; }

//    private int side = 0;

//    public void GetNextArea()
//    {
//        side++;
//        CurrentShapeArea = side * side;
//    }

//    public void ResetSeries()
//    {
//        side = 0;
//        CurrentShapeArea = 0;
//    }
//}

//class CircleSeries : IShapeSeries
//{
//    public int CurrentShapeArea { get; set; }

//    private int radius = 0;

//    public void GetNextArea()
//    {
//        radius++;
//        CurrentShapeArea = (int)(Math.PI * radius * radius);
//    }

//    public void ResetSeries()
//    {
//        radius = 0;
//        CurrentShapeArea = 0;
//    }
//}

//class Program
//{
//    static void PrintTenShapes(IShapeSeries series)
//    {
//        series.ResetSeries();

//        for (int i = 0; i < 10; i++)
//        {
//            series.GetNextArea();
//            Console.WriteLine(series.CurrentShapeArea);
//        }
//    }

//    static void Main()
//    {
//        IShapeSeries square = new SquareSeries();

//        Console.WriteLine("Square Series:");
//        PrintTenShapes(square);

//        IShapeSeries circle = new CircleSeries();

//        Console.WriteLine("\nCircle Series:");
//        PrintTenShapes(circle);
//    }
//} 
//#endregion
//-------------------------------------------------------------
//#region problem2
//using System;

//class Shape : IComparable<Shape>
//{
//    public string Name { get; set; }
//    public double Area { get; set; }

//    public Shape(string name, double area)
//    {
//        Name = name;
//        Area = area;
//    }

//    public int CompareTo(Shape other)
//    {
//        return Area.CompareTo(other.Area);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Shape[] shapes =
//        {
//            new Shape("Square", 25),
//            new Shape("Circle", 12.5),
//            new Shape("Rectangle", 40),
//            new Shape("Square", 9),
//            new Shape("Circle", 30)
//        };

//        Array.Sort(shapes);

//        foreach (Shape shape in shapes)
//        {
//            Console.WriteLine(shape.Name + " - " + shape.Area);
//        }
//    }
//} 
//#endregion
//-------------------------------------
//#region problem3
//using System;

//abstract class GeometricShape
//{
//    public double Dimension1 { get; set; }
//    public double Dimension2 { get; set; }

//    public abstract double CalculateArea();

//    public abstract double Perimeter { get; }
//}

//class Triangle : GeometricShape
//{
//    public Triangle(double dimension1, double dimension2)
//    {
//        Dimension1 = dimension1;
//        Dimension2 = dimension2;
//    }

//    public override double CalculateArea()
//    {
//        return 0.5 * Dimension1 * Dimension2;
//    }

//    public override double Perimeter
//    {
//        get { return 0; }
//    }
//}

//class Rectangle : GeometricShape
//{
//    public Rectangle(double dimension1, double dimension2)
//    {
//        Dimension1 = dimension1;
//        Dimension2 = dimension2;
//    }

//    public override double CalculateArea()
//    {
//        return Dimension1 * Dimension2;
//    }

//    public override double Perimeter
//    {
//        get { return 2 * (Dimension1 + Dimension2); }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        GeometricShape triangle = new Triangle(10, 5);
//        GeometricShape rectangle = new Rectangle(10, 5);

//        Console.WriteLine("Triangle Area: " + triangle.CalculateArea());
//        Console.WriteLine("Triangle Perimeter: " + triangle.Perimeter);

//        Console.WriteLine();

//        Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
//        Console.WriteLine("Rectangle Perimeter: " + rectangle.Perimeter);
//    }
//} 
//#endregion
//-----------------------------------------
using System;

class Program
{
    public static void SelectionSort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = numbers[i];
            numbers[i] = numbers[minIndex];
            numbers[minIndex] = temp;
        }
    }

    static void Main()
    {
        int[] shapeAreas =
        {
            50,
            12,
            30,
            8,
            45,
            20
        };

        Console.WriteLine("Before Sorting:");

        foreach (int area in shapeAreas)
        {
            Console.WriteLine(area);
        }

        SelectionSort(shapeAreas);

        Console.WriteLine("\nAfter Sorting:");

        foreach (int area in shapeAreas)
        {
            Console.WriteLine(area);
        }
    }
}