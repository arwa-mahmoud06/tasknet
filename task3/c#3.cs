// See https://aka.ms/new-console-template for more information
#region problem1
using System.Text;

Console.Write("Enter a number: ");
string input = Console.ReadLine();

try
{
    int number1 = int.Parse(input);
    int number2 = Convert.ToInt32(input);

    Console.WriteLine("Using int.Parse: " + number1);
    Console.WriteLine("Using Convert.ToInt32: " + number2);
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message)
    #endregion;

    #region problem2
        Console.Write("Enter a number: ");
    string inpet = Console.ReadLine();

    if (int.TryParse(input, out int number))
    {
        Console.WriteLine("The number is: " + number);
    }
    else
    {
        Console.WriteLine("Error: Invalid integer.");
    }
    #endregion


    #region problem3

    object obj;

    obj = 10;
    Console.WriteLine("int HashCode: " + obj.GetHashCode());

    obj = "Hello";
    Console.WriteLine("string HashCode: " + obj.GetHashCode());

    obj = 10.5;
    Console.WriteLine("double HashCode: " + obj.GetHashCode());
}
#endregion

#region proble4
class Person
{
    public string Name;
}

Person person1 = new Person();
person1.Name = "Willy";

Person person2 = person1;

person1.Name = "John";

Console.WriteLine(person2.Name);
#endregion

#region problem5
string text = "Hello";

Console.WriteLine("Before: " + text);
Console.WriteLine("HashCode before: " + text.GetHashCode());

text = text + " Hi Willy";

Console.WriteLine("After: " + text);
Console.WriteLine("HashCode after: " + text.GetHashCode()); 
#endregion

#region problem6
		using System.Text;

StringBuilder sb = new StringBuilder("Hello");

Console.WriteLine("HashCode before: " + sb.GetHashCode());

sb.Append(" Hi Willy");

Console.WriteLine("Text after modification: " + sb);
Console.WriteLine("HashCode after: " + sb.GetHashCode());
#endregion


#region problem7
Console.Write("Enter first number: ");
int input1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int input2 = int.Parse(Console.ReadLine());

int sum = input1 + input2;

// Concatenation
Console.WriteLine("Sum is " + input1 + "+" + input2 + " = " + sum);

// Composite formatting
Console.WriteLine(string.Format("Sum is {0}+{1} = {2}", input1, input2, sum));

// String interpolation
Console.WriteLine($"Sum is {input1}+{input2} = {sum}"); 
#endregion

#region problem8
		using System.Text;

StringBuilder sB = new StringBuilder("Hello World");

sB.Append(" Hi");
Console.WriteLine("After Append: " + sB);

sB.Replace("World", "Willy");
Console.WriteLine("After Replace: " + sB);

sB.Insert(6, "My ");
Console.WriteLine("After Insert: " + sB);

sB.Remove(0, 6);
Console.WriteLine("After Remove: " + sB); 
#endregion

