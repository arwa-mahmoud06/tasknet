// See https://aka.ms/new-console-template for more information
//#region problem1
//Employee[] employees =
//{
//    new Employee { Name = "Ahmed", Salary = 8000 },
//    new Employee { Name = "Sara", Salary = 5000 },
//    new Employee { Name = "Omar", Salary = 10000 }
//};

//SortingAlgorithm<Employee>.Sort(employees);

//foreach (var e in employees)
//    Console.WriteLine($"{e.Name} - {e.Salary}");

//class Employee : IComparable<Employee>
//{
//    public string Name { get; set; }
//    public double Salary { get; set; }

//    public int CompareTo(Employee other)
//    {
//        return Salary.CompareTo(other.Salary);
//    }
//}

//class SortingAlgorithm<T> where T : IComparable<T>
//{
//    public static void Sort(T[] array)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            for (int j = 0; j < array.Length - i - 1; j++)
//            {
//                if (array[j].CompareTo(array[j + 1]) > 0)
//                {
//                    T temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                }
//            }
//        }
//    }
//} 
//#endregion
//----------------------------------
//#region problem2

//int[] numbers = { 5, 2, 8, 1, 9 };

//SortingTwo<int>.Sort(numbers, (x, y) => y.CompareTo(x));

//foreach (var n in numbers)
//    Console.WriteLine(n);

//class SortingTwo<T>
//{
//    public static void Sort(T[] arr, Comparison<T> comparison)
//    {
//        Array.Sort(arr, comparison);
//    }
//} 
//#endregion
//------------------------------
//#region problem3
//public static class SortingTwo<T>
//{
//    public static void Sort(T[] arr, Comparison<T> compare)
//    {
//        for (int i = 0; i < arr.Length - 1; i++)
//            for (int j = 0; j < arr.Length - i - 1; j++)
//                if (compare(arr[j], arr[j + 1]) > 0)
//                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
//    }
//} 
//#endregion
//-----------------------------------

//#region problem4
//Manager[] managers =
//{
//    new Manager { Name = "Ahmed", Salary = 8000 },
//    new Manager { Name = "Sara", Salary = 5000 },
//    new Manager { Name = "Omar", Salary = 10000 }
//};

//Array.Sort(managers);

//foreach (var m in managers)
//    Console.WriteLine($"{m.Name} - {m.Salary}");

//class Employee
//{
//    public string Name { get; set; }
//    public double Salary { get; set; }
//}

//class Manager : Employee, IComparable<Manager>
//{
//    public int CompareTo(Manager? other)
//    {
//        if (other is null) return 1;
//        return Salary.CompareTo(other.Salary);
//    }
//} 
//#endregion
//---------------------------------------------

//#region problem5
//Employee[] employees =
//{
//    new Employee { Name = "Ahmed", Salary = 5000 },
//    new Employee { Name = "Mohamed", Salary = 6000 },
//    new Employee { Name = "Ali", Salary = 4000 }
//};

//Array.Sort(employees, (x, y) => x.Name.Length.CompareTo(y.Name.Length));

//foreach (var e in employees)
//    Console.WriteLine($"{e.Name} - {e.Name.Length}");

//class Employee
//{
//    public string Name { get; set; }
//    public double Salary { get; set; }
//} 
//#endregion
//-----------------------

//#region problem6
//int[] numbers = { 5, 2, 9, 1, 7 };

//Comparison<int> anonymousCompare = delegate (int x, int y)
//{
//	return x.CompareTo(y);
//};

//int[] arr1 = (int[])numbers.Clone();
//Array.Sort(arr1, anonymousCompare);
//Console.WriteLine("Anonymous method: " + string.Join(", ", arr1));

//Comparison<int> lambdaCompare = (x, y) => x.CompareTo(y);

//int[] arr2 = (int[])numbers.Clone();
//Array.Sort(arr2, lambdaCompare);
//Console.WriteLine("Lambda: " + string.Join(", ", arr2)); 
//#endregion 
//---------------------------------------

//#region problem7
//using System;

//class SortingAlgorithm<T>
//{
//    public static void Swap<U>(U[] arr, int index1, int index2)
//    {
//        U temp = arr[index1];
//        arr[index1] = arr[index2];
//        arr[index2] = temp;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 10, 20, 30, 40 };

//        SortingAlgorithm<int>.Swap(numbers, 0, 2);

//        foreach (int number in numbers)
//        {
//            Console.Write(number + " ");
//        }
//    }
//} 
//#endregion
//----------------------------


//#region problem8

//using System;

//class Employee
//{
//    public string Name { get; set; }
//    public double Salary { get; set; }
//}

//class SortingTwo<T>
//{
//    public static void Sort(T[] arr, Comparison<T> comparison)
//    {
//        Array.Sort(arr, comparison);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee[] employees =
//        {
//            new Employee { Name = "Ahmed", Salary = 5000 },
//            new Employee { Name = "Omar", Salary = 3000 },
//            new Employee { Name = "Ali", Salary = 5000 },
//            new Employee { Name = "Sara", Salary = 7000 }
//        };

//        SortingTwo<Employee>.Sort(employees, (x, y) =>
//        {
//            int result = x.Salary.CompareTo(y.Salary);

//            if (result == 0)
//            {
//                result = x.Name.CompareTo(y.Name);
//            }

//            return result;
//        });

//        foreach (Employee employee in employees)
//        {
//            Console.WriteLine(employee.Name + " - " + employee.Salary);
//        }
//    }

//#endregion
//------------------------------


//#region problem9
//using System;

//class GenericHelper
//{
//    public static T GetDefault<T>()
//    {
//        return default(T);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int number = GenericHelper.GetDefault<int>();
//        string text = GenericHelper.GetDefault<string>();

//        Console.WriteLine(number);
//        Console.WriteLine(text == null ? "null" : text);
//    }
//}
//#endregion 
//------------------------

//#region problem10
//using System;

//class Employee : ICloneable
//{
//    public string Name { get; set; }
//    public double Salary { get; set; }

//    public object Clone()
//    {
//        return new Employee
//        {
//            Name = this.Name,
//            Salary = this.Salary
//        };
//    }
//}

//class SortingAlgorithm<T> where T : ICloneable
//{
//    public static T[] CloneArray(T[] arr)
//    {
//        T[] result = new T[arr.Length];

//        for (int i = 0; i < arr.Length; i++)
//        {
//            result[i] = (T)arr[i].Clone();
//        }

//        return result;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee[] employees =
//        {
//            new Employee { Name = "Ahmed", Salary = 5000 },
//            new Employee { Name = "Sara", Salary = 3000 },
//            new Employee { Name = "Omar", Salary = 7000 }
//        };

//        Employee[] clonedEmployees =
//            SortingAlgorithm<Employee>.CloneArray(employees);

//        foreach (Employee employee in clonedEmployees)
//        {
//            Console.WriteLine(employee.Name + " - " + employee.Salary);
//        }
//    }
//}

//#endregion
//----------------------------

//#region problem11
//using System;
//using System.Collections.Generic;

//class StringHelper
//{
//    public delegate string StringTransformation(string text);

//    public static List<string> Transform(
//        List<string> strings,
//        StringTransformation transformation)
//    {
//        List<string> result = new List<string>();

//        foreach (string text in strings)
//        {
//            result.Add(transformation(text));
//        }

//        return result;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        List<string> names = new List<string>
//        {
//            "ahmed",
//            "sara",
//            "omar"
//        };

//        List<string> upperNames =
//            StringHelper.Transform(names, text => text.ToUpper());

//        foreach (string name in upperNames)
//        {
//            Console.WriteLine(name);
//        }

//        List<string> reversedNames =
//            StringHelper.Transform(names, text =>
//            {
//                char[] chars = text.ToCharArray();
//                Array.Reverse(chars);
//                return new string(chars);
//            });

//        foreach (string name in reversedNames)
//        {
//            Console.WriteLine(name);
//        }
//    }
//} 
//#endregion
//------------------------------------------------

//#region problem12
//using System;

//class Program
//{
//    delegate int Operation(int x, int y);

//    static int Calculate(int x, int y, Operation operation)
//    {
//        return operation(x, y);
//    }

//    static void Main()
//    {
//        Console.WriteLine(Calculate(10, 5, (x, y) => x + y));
//        Console.WriteLine(Calculate(10, 5, (x, y) => x - y));
//        Console.WriteLine(Calculate(10, 5, (x, y) => x * y));
//        Console.WriteLine(Calculate(10, 5, (x, y) => x / y));
//    }
//} 
//#endregion
//---------------------------

//#region probkem13
//using System;
//using System.Collections.Generic;

//class Program
//{
//    delegate R Transform<T, R>(T value);

//    static List<R> ConvertList<T, R>(
//        List<T> list,
//        Transform<T, R> transform)
//    {
//        List<R> result = new List<R>();

//        foreach (T item in list)
//        {
//            result.Add(transform(item));
//        }

//        return result;
//    }

//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

//        List<string> result = ConvertList<int, string>(
//            numbers,
//            number => number.ToString()
//        );

//        foreach (string item in result)
//        {
//            Console.WriteLine(item);
//        }
//    }
//} 
//#endregion
//------------------------

//#region problem14
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static List<int> ApplyFunction(
//        List<int> numbers,
//        Func<int, int> function)
//    {
//        List<int> result = new List<int>();

//        foreach (int number in numbers)
//        {
//            result.Add(function(number));
//        }

//        return result;
//    }

//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

//        List<int> squares = ApplyFunction(
//            numbers,
//            number => number * number
//        );

//        foreach (int number in squares)
//        {
//            Console.WriteLine(number);
//        }
//    }
//} 
//#endregion
//----------------------------------

//#region problem16
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static List<int> Filter(
//        List<int> numbers,
//        Predicate<int> condition)
//    {
//        List<int> result = new List<int>();

//        foreach (int number in numbers)
//        {
//            if (condition(number))
//            {
//                result.Add(number);
//            }
//        }

//        return result;
//    }

//    static void Main()
//    {
//        List<int> numbers = new List<int>
//        {
//            1, 2, 3, 4, 5, 6, 7, 8
//        };

//        List<int> evenNumbers = Filter(
//            numbers,
//            number => number % 2 == 0
//        );

//        foreach (int number in evenNumbers)
//        {
//            Console.WriteLine(number);
//        }
//    }
//} 
//#endregion
//----------------------

//#region problem17
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static List<string> FilterStrings(
//        List<string> words,
//        Predicate<string> condition)
//    {
//        List<string> result = new List<string>();

//        foreach (string word in words)
//        {
//            if (condition(word))
//            {
//                result.Add(word);
//            }
//        }

//        return result;
//    }

//    static void Main()
//    {
//        List<string> words = new List<string>
//        {
//            "apple",
//            "banana",
//            "orange",
//            "cat",
//            "application"
//        };

//        List<string> startsWithA = FilterStrings(
//            words,
//            delegate (string word)
//            {
//                return word.StartsWith("a");
//            });

//        foreach (string word in startsWithA)
//        {
//            Console.WriteLine(word);
//        }

//        List<string> containsApp = FilterStrings(
//            words,
//            delegate (string word)
//            {
//                return word.Contains("app");
//            });

//        foreach (string word in containsApp)
//        {
//            Console.WriteLine(word);
//        }
//    }
//} 
//#endregion
//-------------------------------

using System;

class Program
{
    delegate double Operation(double x, double y);

    static double Calculate(
        double x,
        double y,
        Operation operation)
    {
        return operation(x, y);
    }

    static void Main()
    {
        double division = Calculate(
            10,
            2,
            (x, y) => x / y
        );

        double power = Calculate(
            2,
            3,
            (x, y) => Math.Pow(x, y)
        );

        Console.WriteLine(division);
        Console.WriteLine(power);
    }
}