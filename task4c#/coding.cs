// See https://aka.ms/new-console-template for more information
#region problem1
// 1. Using new int[size]
int[] arr1 = new int[3];

arr1[0] = 10;
arr1[1] = 20;
arr1[2] = 30;

Console.WriteLine("Array 1:");
for (int i = 0; i < arr1.Length; i++)
{
    Console.WriteLine(arr1[i]);
}


// 2. Using initializer list
int[] arr2 = new int[] { 40, 50, 60 };

Console.WriteLine("Array 2:");
for (int i = 0; i < arr2.Length; i++)
{
    Console.WriteLine(arr2[i]);
}


// 3. Array syntax sugar
int[] arr3 = { 70, 80, 90 };

Console.WriteLine("Array 3:");
for (int i = 0; i < arr3.Length; i++)
{
    Console.WriteLine(arr3[i]);
}


// IndexOutOfRangeException
try
{
    Console.WriteLine(arr1[3]);
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Index is out of range!");
}

#endregion

#region problem2
// Create arr1
int[] ar1 = { 10, 20, 30 };

// Shallow Copy
int[] ar2 = ar1;

Console.WriteLine("Before modification:");
Console.WriteLine("arr1[0] = " + ar1[0]);
Console.WriteLine("arr2[0] = " + ar2[0]);

// Modify arr2
ar2[0] = 100;

Console.WriteLine("\nAfter modifying arr2:");
Console.WriteLine("arr1[0] = " + ar1[0]);
Console.WriteLine("arr2[0] = " + ar2[0]);


// Deep Copy using Clone
int[] ar3 = (int[])ar1.Clone();

// Modify arr3
ar3[1] = 200;

Console.WriteLine("\nAfter modifying arr3:");
Console.WriteLine("arr1[1] = " + ar1[1]);
Console.WriteLine("arr3[1] = " + ar3[1]);
#endregion

#region problem3
int[] numbers = { 10, 20, 30, 40, 50 };

// Using for loop
Console.WriteLine("Using for loop:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

// Using foreach loop
Console.WriteLine("\nUsing foreach loop:");
foreach (int numbr in numbers)
{
    Console.WriteLine(numbr);
}

// Using while loop in reverse order
Console.WriteLine("\nUsing while loop in reverse:");
int j = numbers.Length - 1;

while (j >= 0)
{
    Console.WriteLine(numbers[j]);
    j--;
}
#endregion

#region problem4
int number;

do
{
    Console.Write("Enter a positive odd number: ");

    if (int.TryParse(Console.ReadLine(), out number))
    {
        if (number > 0 && number % 2 != 0)
        {
            Console.WriteLine("Valid number!");
            break;
        }
        else
        {
            Console.WriteLine("Please enter a positive odd number.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }

} while (true);

#endregion


#region problem5

int[,] grades =
{
    { 90, 85, 88 },
    { 75, 80, 82 },
    { 95, 91, 89 }
};

for (int i = 0; i < grades.GetLength(0); i++)
{
    for (int x = 0; x < grades.GetLength(1); x++)
    {
        Console.Write(grades[i, x] + "\t");
    }

    Console.WriteLine();
}


#endregion

#region problem6

Console.Write("Enter month number: ");
int month = int.Parse(Console.ReadLine());

// Using if-else
if (month == 1)
    Console.WriteLine("January");
else if (month == 2)
    Console.WriteLine("February");
else if (month == 3)
    Console.WriteLine("March");
else if (month == 4)
    Console.WriteLine("April");
else if (month == 5)
    Console.WriteLine("May");
else if (month == 6)
    Console.WriteLine("June");
else if (month == 7)
    Console.WriteLine("July");
else if (month == 8)
    Console.WriteLine("August");
else if (month == 9)
    Console.WriteLine("September");
else if (month == 10)
    Console.WriteLine("October");
else if (month == 11)
    Console.WriteLine("November");
else if (month == 12)
    Console.WriteLine("December");
else
    Console.WriteLine("Invalid month");

// Using switch
switch (month)
{
    case 1:
        Console.WriteLine("January");
        break;
    case 2:
        Console.WriteLine("February");
        break;
    case 3:
        Console.WriteLine("March");
        break;
    case 4:
        Console.WriteLine("April");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    case 6:
        Console.WriteLine("June");
        break;
    case 7:
        Console.WriteLine("July");
        break;
    case 8:
        Console.WriteLine("August");
        break;
    case 9:
        Console.WriteLine("September");
        break;
    case 10:
        Console.WriteLine("October");
        break;
    case 11:
        Console.WriteLine("November");
        break;
    case 12:
        Console.WriteLine("December");
        break;
    default:
        Console.WriteLine("Invalid month");
        break;
}
#endregion

#region problem7
int[] num = { 5, 2, 8, 2, 10, 3 };

Array.Sort(num);

Console.WriteLine("Sorted array:");

for (int i = 0; i < num.Length; i++)
{
    Console.Write(num[i] + " ");
}

Console.WriteLine();

int value = 2;

int firstIndex = Array.IndexOf(num, value);
int lastIndex = Array.LastIndexOf(num, value);

Console.WriteLine("First index of 2: " + firstIndex);
Console.WriteLine("Last index of 2: " + lastIndex);
#endregion
#region problem8

int[] numberss = { 10, 20, 30, 40, 50 };

// Using for loop
int sumFor = 0;

for (int a = 0; a < numberss.Length; a++)
{
    sumFor += numbers[a];
}

Console.WriteLine("Sum using for: " + sumFor);

// Using foreach loop
int sumForeach = 0;

foreach (int numbes in numberss)
{
    sumForeach += numbes;
}

Console.WriteLine("Sum using foreach: " + sumForeach); 
#endregion

//part 2
using System;

enum DayOfWeek
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
}

class Program
{
    static void Main()
    {
        Console.Write("Enter a number from 1 to 7: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 1 && number <= 7)
        {
            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), number.ToString());

            Console.WriteLine("The corresponding day is: " + day);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number from 1 to 7.");
        }
    }
}