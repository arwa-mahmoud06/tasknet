// See https://aka.ms/new-console-template for more information
//#region problem1
//class Helper
//{
//    public static T[] ReverseArray<T>(T[] arr)
//    {
//        T[] result = new T[arr.Length];

//        for (int i = 0; i < arr.Length; i++)
//        {
//            result[i] = arr[arr.Length - 1 - i];
//        }

//        return result;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };

//        int[] result = Helper.ReverseArray(numbers);

//        foreach (int number in result)
//            Console.Write(number + " ");
//    }
//} 
//#endregion
//----------------------------------------


//#region problem2
//class MyStack<T>
//{
//    private List<T> items = new List<T>();

//    public void Push(T item)
//    {
//        items.Add(item);
//    }

//    public T Pop()
//    {
//        T item = items[items.Count - 1];
//        items.RemoveAt(items.Count - 1);
//        return item;
//    }

//    public T Peek()
//    {
//        return items[items.Count - 1];
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        MyStack<int> stack = new MyStack<int>();

//        stack.Push(10);
//        stack.Push(20);
//        stack.Push(30);

//        Console.WriteLine(stack.Peek());
//        Console.WriteLine(stack.Pop());
//        Console.WriteLine(stack.Pop());
//    }
//} 
//#endregion
//---------------------------

//#region problem3
//class Helper
//{
//    public static void Swap<T>(T[] arr, int index1, int index2)
//    {
//        T temp = arr[index1];
//        arr[index1] = arr[index2];
//        arr[index2] = temp;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 10, 20, 30, 40 };

//        Helper.Swap(numbers, 0, 3);

//        foreach (int number in numbers)
//            Console.Write(number + " ");
//    }
//} 
//#endregion
//--------------------------------


class Helper
{
    public static T Max<T>(T[] arr) where T : IComparable<T>
    {
        T max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i].CompareTo(max) > 0)
            {
                max = arr[i];
            }
        }

        return max;
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 50, 20, 90, 30 };

        int max = Helper.Max(numbers);

        Console.WriteLine($"Maximum = {max}");
    }
}