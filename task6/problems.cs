// See https://aka.ms/new-console-template for more information
//#region problem1
//using System;

//struct Point
//{
//    public int X;
//    public int Y;

//    public Point()
//    {
//        X = 0;
//        Y = 0;
//    }

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Point p1 = new Point();
//        Point p2 = new Point(5, 10);

//        Console.WriteLine(p1);
//        Console.WriteLine(p2);
//    }
//} 
//#endregion
//-----------------------------------

//#region problem2
//using System;

//class TypeA
//{
//    private int F = 10;
//    internal int G = 20;
//    public int H = 30;

//    public void Display()
//    {
//        Console.WriteLine(F);
//        Console.WriteLine(G);
//        Console.WriteLine(H);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        TypeA obj = new TypeA();

//        Console.WriteLine(obj.G);
//        Console.WriteLine(obj.H);

//        obj.Display();
//    }
//} 
//#endregion
//---------------------------------------------
//#region problem3

//using System;

//struct Employee
//{
//    private int EmpId;
//    private string Name;
//    private double Salary;

//    public string GetName()
//    {
//        return Name;
//    }

//    public void SetName(string name)
//    {
//        Name = name;
//    }

//    public int EmployeeId
//    {
//        get { return EmpId; }
//        set { EmpId = value; }
//    }

//    public double EmployeeSalary
//    {
//        get { return Salary; }
//        set { Salary = value; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee emp = new Employee();

//        emp.EmployeeId = 101;
//        emp.SetName("Arwa");
//        emp.EmployeeSalary = 15000;

//        Console.WriteLine(emp.EmployeeId);
//        Console.WriteLine(emp.GetName());
//        Console.WriteLine(emp.EmployeeSalary);
//    }
//} 
//#endregion
//-----------------------------------------------------------------------
//#region problem4
//using System;

//struct Point
//{
//    public int X;
//    public int Y;

//    public Point(int x)
//    {
//        X = x;
//        Y = 0;
//    }

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Point p1 = new Point(5);
//        Point p2 = new Point(10, 20);

//        Console.WriteLine($"({p1.X}, {p1.Y})");
//        Console.WriteLine($"({p2.X}, {p2.Y})");
//    }
//}

//#endregion
//------------------------------------------------------------------
//#region problem5
//using System;

//struct Point
//{
//    public int X;
//    public int Y;

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public override string ToString()
//    {
//        return $"Point: X = {X}, Y = {Y}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Point p1 = new Point(5, 10);
//        Point p2 = new Point(20, 30);
//        Point p3 = new Point(-5, 15);

//        Console.WriteLine(p1);
//        Console.WriteLine(p2);
//        Console.WriteLine(p3);
//    }
//}

//#endregion
//------------------------------------------------------------------------
#region problem6
using System;
using System.Xml.Linq;

struct Point
{
    public int X;
    public int Y;
}

class Employee
{
    public string Name;
}

class Program
{
    static void ChangePoint(Point p)
    {
        p.X = 100;
        p.Y = 200;
    }

    static void ChangeEmployee(Employee e)
    {
        e.Name = "Ahmed";
    }

    static void Main()
    {
        Point p = new Point();
        p.X = 10;
        p.Y = 20;

        Employee emp = new Employee();
        emp.Name = "Arwa";

        ChangePoint(p);
        ChangeEmployee(emp);

        Console.WriteLine($"Point: ({p.X}, {p.Y})");
        Console.WriteLine($"Employee: {emp.Name}");
    }
}
#endregion


//part 2 q1
//1.What is Copy Constructor ?

//A copy constructor is a constructor that creates a new object by copying the values from another object of the same class.

//يعني ببساطة: عندي object قديم، وعايزة أعمل object جديد بنفس البيانات بتاعته.

//public Employee(Employee emp)
//{
//    Name = emp.Name;
//    Salary = emp.Salary;
//}
//q3-----
//3.What is Indexer ? When is it used ?

//An Indexer allows us to access the data inside a class or object using an index, just like an array.

//يعني بدل ما أعمل method مخصوص عشان أجيب كل value، أقدر أكتب:

//obj[0]

//When do we use it?

//We can use an indexer when our class contains a collection of data and we want to access its elements easily.

//Business cases:

//A Student class containing student grades.
//A ProductCatalog containing products.
//A CustomerList containing customers.
//A Library containing books.

//Example:

//public string this[int index]
//{
//    get { return names[index]; }
//}

//Then we can use:

//obj[0]
