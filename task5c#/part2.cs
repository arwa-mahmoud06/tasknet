// See https://aka.ms/new-console-template for more information
using System;

//class program
//{
//    static void Main()
//    {
//        // 1. print numbers in a range
//        Console.Write("enter a positive integer: ");
//        int number = int.Parse(Console.ReadLine());

//        for (int i = 1; i <= number; i++)
//        {
//            Console.Write(i + " ");
//        }

//        Console.WriteLine();

//        // 2. multiplication table
//        Console.Write("enter an integer: ");
//        int number2 = int.Parse(Console.ReadLine());

//        for (int i = 1; i <= 12; i++)
//        {
//            Console.Write(number2 * i + " ");
//        }

//        Console.WriteLine();

//        // 3. list even numbers
//        Console.Write("enter a number: ");
//        int number3 = int.Parse(Console.ReadLine());

//        for (int i = 1; i <= number3; i++)
//        {
//            if (i % 2 == 0)
//            {
//                Console.Write(i + " ");
//            }
//        }

//        Console.WriteLine();

//        // 4. compute exponentiation
//        Console.Write("enter the base: ");
//        int number4 = int.Parse(Console.ReadLine());

//        Console.Write("enter the power: ");
//        int power = int.Parse(Console.ReadLine());

//        int result = 1;

//        for (int i = 1; i <= power; i++)
//        {
//            result = result * number4;
//        }

//        Console.WriteLine("result = " + result);
//    }
//}
using System;

class program
{
    static void Main()
    {
        // 1. reverse a string
        Console.Write("enter a string: ");
        string text = Console.ReadLine();

        for (int i = text.Length - 1; i >= 0; i--)
        {
            Console.Write(text[i]);
        }

        Console.WriteLine();

        // 2. reverse an integer
        Console.Write("enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        int reverse = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reverse = reverse * 10 + digit;
            number = number / 10;
        }

        Console.WriteLine(reverse);

        // 3. longest distance between matching elements
        Console.Write("enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("enter element: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int maxDistance = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    int distance = j - i - 1;

                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                    }
                }
            }
        }

        Console.WriteLine("longest distance = " + maxDistance);

        // 4. reverse words in a sentence
        Console.Write("enter a sentence: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');

        Array.Reverse(words);

        Console.WriteLine(string.Join(" ", words));
    }
}