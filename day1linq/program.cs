// See https://aka.ms/new-console-template for more information
//#region part1num1
//var number = 10;
//var name = "Arwa";
//var price = 25.5;
//var isActive = true;
//var numbers = new int[] { 1, 2, 3 };

//Console.WriteLine(number.GetType());
//Console.WriteLine(name.GetType());
//Console.WriteLine(price.GetType());
//Console.WriteLine(isActive.GetType());
//Console.WriteLine(numbers.GetType()); 
//#endregion
//------------------

//#region part1num2
//int age = 19;
//string name = "Arwa";
//double salary = 5000.5;
//bool isStudent = true;

//// Using var
//var age2 = 19;
//var name2 = "Arwa";
//var salary2 = 5000.5;
//var isStudent2 = true;

////  result is the same 

//#endregion
//-----------------------
//#region part2num3
//var product = new
//{
//    Name = "Laptop",
//    Price = 25000,
//    Quantity = 2
//};

//Console.WriteLine(product.Name);
//Console.WriteLine(product.Price);
//Console.WriteLine(product.Quantity); 
//#endregion
//-----------------------

//#region part2num4
//var students = new[]
//{
//    new { Name = "Arwa", Grade = 85 },
//    new { Name = "salma", Grade = 90 },
//    new { Name = "yara", Grade = 78 }
//};

//foreach (var student in students)
//{
//    Console.WriteLine("Name: " + student.Name);
//    Console.WriteLine("Grade: " + student.Grade);
//} 
//#endregion
//------------------

//#region part2num5
//var order = new
//{
//    OrderId = 101,
//    Customer = new
//    {
//        Name = "Arwa",
//        City = "Qalyubia"
//    }
//};

//Console.WriteLine("Order ID: " + order.OrderId);
//Console.WriteLine("Customer Name: " + order.Customer.Name);
//Console.WriteLine("City: " + order.Customer.City); 
//#endregion
//-----------------

//#region part3num6
//public static class StringExtensions
//{
//    public static bool IsPalindrome(this string text)
//    {
//        for (int i = 0; i < text.Length / 2; i++)
//        {
//            if (text[i] != text[text.Length - 1 - i])
//            {
//                return false;
//            }
//        }

//        return true;
//    }
//}

//#endregion
//-------------------

//#region part3num7
//public static class IntExtensions
//{
//    public static bool IsPrime(this int number)
//    {
//        if (number < 2)
//        {
//            return false;
//        }

//        for (int i = 2; i < number; i++)
//        {
//            if (number % i == 0)
//            {
//                return false;
//            }
//        }

//        return true;
//    }
//}
//#endregion
//------------------------

//#region part3num8
//public static class ArrayExtensions
//{
//    public static int Sum(this int[] numbers)
//    {
//        int total = 0;

//        foreach (int number in numbers)
//        {
//            total += number;
//        }

//        return total;
//    }
//}

//#endregion
//---------------------

//part4
//#region problem9
//List<string> employees = new List<string>();

//employees.Add("Arwa");
//employees.Add("sara");
//employees.Add("ahmed");
//employees.Add("mostafa");

//employees.Remove("ahmed");

//string searchName = "sara";
//bool found = false;

//foreach (string employee in employees)
//{
//    if (employee == searchName)
//    {
//        found = true;
//        break;
//    }
//}

//Console.WriteLine("Found: " + found);

//foreach (string employee in employees)
//{
//    Console.WriteLine(employee);
//}

//#endregion
//---------------

//#region problem10
//using System;
//using System.Collections.Generic;

//List<Employee> employees = new List<Employee>();

//employees.Add(new Employee { Name = "Arwa", Salary = 5000 });
//employees.Add(new Employee { Name = "ahmed", Salary = 8000 });
//employees.Add(new Employee { Name = "salma", Salary = 4000 });

//double value = 5000;

//foreach (Employee employee in employees)
//{
//    if (employee.Salary > value)
//    {
//        Console.WriteLine(employee.Name + " - " + employee.Salary);
//    }
//}

//class Employee
//{
//    public string Name { get; set; }
//    public double Salary { get; set; }
//} 
//#endregion
//-----------------
//#region problem11

//Dictionary<string, int> products = new Dictionary<string, int>();

//products.Add("Laptop", 25000);
//products.Add("Phone", 15000);
//products.Add("Mouse", 500);

//foreach (KeyValuePair<string, int> product in products)
//{
//	Console.WriteLine(product.Key + " - " + product.Value);
//} 
//#endregion
//-----------------

using System;
using System.Diagnostics;
using System.Linq.Expressions;

Dictionary<int, string> students = new Dictionary<int, string>();

students.Add(1, "Arwa");
students.Add(2, "ahmed");
students.Add(3, "sara");

Console.Write("Enter student ID: ");
int id = int.Parse(Console.ReadLine());

string name;

if (students.TryGetValue(id, out name))
{
    Console.WriteLine("Student Name: " + name);
}
else
{
    Console.WriteLine("Student not found");
}

//1.

//A delegate is a type that can hold a reference to a method, while a lambda expression is a short way to write a method or function. A lambda can be used with a delegate.

//2.

//var is still statically typed because the compiler knows the variable's type from the value assigned to it at compile time. The type cannot change later.

//3.

//An anonymous type is useful when I need a temporary object to hold a few related values, for example, getting student name and grade from a database without needing to create a separate Student class.