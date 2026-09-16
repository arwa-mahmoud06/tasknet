// See https://aka.ms/new-console-template for more information

//#region problem1
//enum Weekdays
//{
//    Monday = 1,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday
//}

//class Program
//{
//    static void Main()
//    {
//        foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
//        {
//            Console.WriteLine($"{day} = {(int)day}");
//        }
//    }
//} 
//#endregion
//-----------------------------------------

//#region problem2
//enum Grades : short
//{
//    F = 1,
//    D,
//    C,
//    B,
//    A
//}

//class Program
//{
//    static void Main()
//    {
//        foreach (Grades grade in Enum.GetValues(typeof(Grades)))
//        {
//            Console.WriteLine($"{grade} = {(short)grade}");
//        }
//    }
//} 
//#endregion
//---------------------------------------------

//#region problem3
//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public string Department { get; set; }

//    public void DisplayDetails()
//    {
//        Console.WriteLine($"Name: {Name}");
//        Console.WriteLine($"Age: {Age}");
//        Console.WriteLine($"Department: {Department}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person person1 = new Person();
//        person1.Name = "Ahmed";
//        person1.Age = 20;
//        person1.Department = "IT";

//        Person person2 = new Person();
//        person2.Name = "Mona";
//        person2.Age = 21;
//        person2.Department = "HR";

//        person1.DisplayDetails();
//        Console.WriteLine();

//        person2.DisplayDetails();
//    }
//} 
//#endregion
//---------------------------------------------

//#region problem4
//class Person
//{
//    public string Name { get; set; }
//}

//class Child : Person
//{
//    public sealed decimal Salary { get; set; }

//    public void DisplaySalary()
//    {
//        Console.WriteLine($"Salary: {Salary}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Child child = new Child();

//        child.Name = "Ahmed";
//        child.Salary = 5000;

//        child.DisplaySalary();
//    }
//} 
//#endregion
//-----------------------------------------------

//#region problem5
//class Utility
//{
//    public static double CalculatePerimeter(double length, double width)
//    {
//        return 2 * (length + width);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        double perimeter = Utility.CalculatePerimeter(10, 5);

//        Console.WriteLine($"Perimeter = {perimeter}");
//    }
//} 
//#endregion
//------------------------------------

//#region problem6
//class ComplexNumber
//{
//    public double Real { get; set; }
//    public double Imaginary { get; set; }

//    public ComplexNumber(double real, double imaginary)
//    {
//        Real = real;
//        Imaginary = imaginary;
//    }

//    public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
//    {
//        double real = (c1.Real * c2.Real) - (c1.Imaginary * c2.Imaginary);
//        double imaginary = (c1.Real * c2.Imaginary) + (c1.Imaginary * c2.Real);

//        return new ComplexNumber(real, imaginary);
//    }

//    public void Display()
//    {
//        Console.WriteLine($"{Real} + {Imaginary}i");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ComplexNumber c1 = new ComplexNumber(2, 3);
//        ComplexNumber c2 = new ComplexNumber(4, 5);

//        ComplexNumber result = c1 * c2;

//        result.Display();
//    }
//} 
//#endregion
//----------------------------------

//#region problem7
//enum GenderDefault
//{
//    Male,
//    Female
//}

//enum GenderByte : byte
//{
//    Male,
//    Female
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine($"Default enum size: {sizeof(int)} byte");
//        Console.WriteLine($"Byte enum size: {sizeof(byte)} byte");

//        GenderDefault gender1 = GenderDefault.Male;
//        GenderByte gender2 = GenderByte.Female;

//        Console.WriteLine(gender1);
//        Console.WriteLine(gender2);
//    }
//} 
//#endregion
//------------------------------------------

//#region problem8
//class Utility
//{
//    public static double CelsiusToFahrenheit(double celsius)
//    {
//        return (celsius * 9 / 5) + 32;
//    }

//    public static double FahrenheitToCelsius(double fahrenheit)
//    {
//        return (fahrenheit - 32) * 5 / 9;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        double f = Utility.CelsiusToFahrenheit(25);
//        double c = Utility.FahrenheitToCelsius(77);

//        Console.WriteLine($"25 Celsius = {f} Fahrenheit");
//        Console.WriteLine($"77 Fahrenheit = {c} Celsius");
//    }
//} 
//#endregion
//-------------------------------

//#region problem9
//enum Grades
//{
//    F = 1,
//    D,
//    C,
//    B,
//    A
//}

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter grade: ");
//        string input = Console.ReadLine();

//        if (Enum.TryParse(input, true, out Grades grade))
//        {
//            Console.WriteLine($"Grade: {grade}");
//            Console.WriteLine($"Value: {(int)grade}");
//        }
//        else
//        {
//            Console.WriteLine("Invalid grade");
//        }
//    }
//} 
//#endregion
//------------------------------------

//#region problem10
//class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public override bool Equals(object obj)
//    {
//        if (obj is Employee employee)
//            return Id == employee.Id;

//        return false;
//    }

//    public override int GetHashCode()
//    {
//        return Id.GetHashCode();
//    }
//}

//class Helper2<T>
//{
//    public static int SearchArray(T[] arr, T value)
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i].Equals(value))
//                return i;
//        }

//        return -1;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee[] employees =
//        {
//            new Employee { Id = 1, Name = "Ahmed" },
//            new Employee { Id = 2, Name = "Mona" },
//            new Employee { Id = 3, Name = "Ali" }
//        };

//        Employee searchEmployee = new Employee { Id = 2, Name = "Mona" };

//        int index = Helper2<Employee>.SearchArray(employees, searchEmployee);

//        Console.WriteLine($"Employee found at index: {index}");
//    }
//} 
//#endregion
//---------------------------

//#region problem11
//class Helper
//{
//    public static T Max<T>(T value1, T value2) where T : IComparable<T>
//    {
//        return value1.CompareTo(value2) > 0 ? value1 : value2;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine(Helper.Max(10, 20));
//        Console.WriteLine(Helper.Max(5.5, 3.2));
//        Console.WriteLine(Helper.Max("Ahmed", "Mona"));
//    }
//} 
//#endregion
//---------------------------------------

//#region problem12
//class Helper2<T>
//{
//    public static void ReplaceArray(T[] arr, T oldValue, T newValue)
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i].Equals(oldValue))
//            {
//                arr[i] = newValue;
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 1, 3, 1 };

//        Helper2<int>.ReplaceArray(numbers, 1, 9);

//        foreach (int number in numbers)
//            Console.Write(number + " ");

//        Console.WriteLine();

//        string[] names = { "Ali", "Mona", "Ali", "Ahmed" };

//        Helper2<string>.ReplaceArray(names, "Ali", "Sara");

//        foreach (string name in names)
//            Console.Write(name + " ");
//    }
//} 
//#endregion
//------------------------------------------

//#region problem13
//struct Rectangle
//{
//    public double Length { get; set; }
//    public double Width { get; set; }
//}

//class Helper
//{
//    public static void Swap(ref Rectangle r1, ref Rectangle r2)
//    {
//        Rectangle temp = r1;
//        r1 = r2;
//        r2 = temp;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Rectangle r1 = new Rectangle { Length = 10, Width = 5 };
//        Rectangle r2 = new Rectangle { Length = 20, Width = 15 };

//        Console.WriteLine($"Before: r1 = {r1.Length}, {r1.Width}");
//        Console.WriteLine($"Before: r2 = {r2.Length}, {r2.Width}");

//        Helper.Swap(ref r1, ref r2);

//        Console.WriteLine($"After: r1 = {r1.Length}, {r1.Width}");
//        Console.WriteLine($"After: r2 = {r2.Length}, {r2.Width}");
//    }
//} 
//#endregion
//-----------------------------------------

#region problem14
class Department
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Department department)
            return Id == department.Id;

        return false;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Department Department { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Employee employee)
            return Id == employee.Id;

        return false;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

class Helper2<T>
{
    public static int SearchArray(T[] arr, T value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Equals(value))
                return i;
        }

        return -1;
    }
}

class Program
{
    static void Main()
    {
        Department it = new Department { Id = 1, Name = "IT" };
        Department hr = new Department { Id = 2, Name = "HR" };

        Employee[] employees =
        {
            new Employee { Id = 1, Name = "Ahmed", Department = it },
            new Employee { Id = 2, Name = "Mona", Department = hr },
            new Employee { Id = 3, Name = "Ali", Department = it }
        };

        Department searchDepartment = new Department
        {
            Id = 1,
            Name = "IT"
        };

        foreach (Employee employee in employees)
        {
            if (employee.Department.Equals(searchDepartment))
            {
                Console.WriteLine($"{employee.Name} - {employee.Department.Name}");
            }
        }
    }
}
#endregion



