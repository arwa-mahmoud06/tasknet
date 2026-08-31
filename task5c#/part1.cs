// See https://aka.ms/new-console-template for more information
#region problem1
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first integer: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int y = int.Parse(Console.ReadLine());

            int result = x / y;

            Console.WriteLine("Result = " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Operation complete.");
        }
    }
}
#endregion


#region problem2

class Programm
{
    static void TestDefensiveCode(int a, int b)
    {
        if (a <= 0)
        {
            Console.WriteLine("a must be a positive integer.");
            return;
        }
        if (b <= 1)
        {
            Console.WriteLine("b must be greater than 1.");
            return;
        }
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }

    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter y: ");
        int b = int.Parse(Console.ReadLine());

        TestDefensiveCode(a, b);
    }
}
#endregion

#region problem3
class Progra
{
    static void Main()
    {
        int? number = null;
        int result = number ?? 10;
        Console.WriteLine("Default value: " + result);

        if (number.HasValue)
        {
            Console.WriteLine("Value: " + number.Value);
        }
        else
        {
            Console.WriteLine("Number has no value.");
        }

        number = 20;
        Console.WriteLine("Has value: " + number.HasValue);
        Console.WriteLine("Value: " + number.Value);
    }
}

#endregion



#region problem4
class Prgram
{
    static void Main()
    {
        int[] numbers = new int[5];
        try
        {
            Console.WriteLine(numbers[5]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index is out of range.");
        }
    }
}
#endregion


#region problem5
class Progrram
{
    static void Main()
    {
        int[,] numbers = new int[3, 3];

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write("Enter value: ");
                numbers[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                rowSum += numbers[i, j];
            }
            Console.WriteLine("Sum of row " + (i + 1) + " = " + rowSum);
        }

        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            int columnSum = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                columnSum += numbers[i, j];
            }
            Console.WriteLine("Sum of column " + (j + 1) + " = " + columnSum);
        }
    }
}
#endregion
#region problem6

class Proggram
{
    static void Main()
    {
        int[][] numbers = new int[3][];
        numbers[0] = new int[2];
        numbers[1] = new int[3];
        numbers[2] = new int[4];

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers[i].Length; j++)
            {
                Console.Write("Enter value for row " + (i + 1) + ": ");
                numbers[i][j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Row " + (i + 1) + ": ");
            for (int j = 0; j < numbers[i].Length; j++)
            {
                Console.Write(numbers[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
#endregion

#region problem7
class Pprogram
{
    static void Main()
    {
        string? name = null;
        Console.Write("Do you want to enter your name? (yes/no): ");
        string? answer = Console.ReadLine();

        if (answer == "yes")
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
        }

        if (name != null)
        {
            Console.WriteLine("Hello " + name!);
        }
        else
        {
            Console.WriteLine("No name was entered.");
        }
    }
}
#endregion

#region problem8

class Pلbrogram
{
    static void Main()
    {
        int number = 10;
        object obj = number;
        int unboxedNumber = (int)obj;

        Console.WriteLine("Boxed value: " + obj);
        Console.WriteLine("Unboxed value: " + unboxedNumber);

        try
        {
            string text = (string)obj;
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Invalid cast exception.");
        }
    }
}
#endregion


#region problem9

class Programmm
{
    static void SumAndMultiply(int o, int r, out int sum, out int product)
    {
        sum = o + r;
        product = o * r;
    }

    static void Main()
    {
        int sum;
        int product;
        SumAndMultiply(5, 4, out sum, out product);
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Product = " + product);
    }
}


#endregion


#region problem10
class Proogram
{
    static void PrintString(string text, int times = 5)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine(text);
        }
    }

    static void Main()
    {
        PrintString(text: "hello", times: 3);
    }
}
#endregion


#region problem11
class Progaram
{
    static void Main()
    {
        int[]? numbers = null;
        int? length = numbers?.Length;
        Console.WriteLine("Array length: " + length);

        numbers = new int[] { 10, 20, 30 };
        length = numbers?.Length;
        Console.WriteLine("Array length: " + length);
    }
}
#endregion



#region problem12
class Progrham
{
    static void Main()
    {
        Console.Write("Enter a day: ");
        string day = Console.ReadLine();

        int number = day.ToLower() switch
        {
            "monday" => 1,
            "tuesday" => 2,
            "wednesday" => 3,
            "thursday" => 4,
            "friday" => 5,
            "saturday" => 6,
            "sunday" => 7,
            _ => 0
        };

        Console.WriteLine("Number = " + number);
    }
}
#endregion


#region problem13
class Proagram
{
    static int SumArray(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static void Main()
    {
        int result1 = SumArray(1, 2, 3, 4);

        int[] numbers = { 5, 6, 7, 8 };
        int result2 = SumArray(numbers);

        Console.WriteLine("Sum of individual values = " + result1);
        Console.WriteLine("Sum of array values = " + result2);
    }
} 
#endregion