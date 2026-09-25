// See https://aka.ms/new-console-template for more information
//#region problem1 restriction
//using day10_G01;

//var result = ListGenerators.ProductList.Where(p => p.UnitsInStock == 0);

//foreach (var p in result)
//	Console.WriteLine(p);


//#endregion
//----------------
//#region problem2
//using day10_G01;

//var result = ListGenerators.ProductList
//    .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

//foreach (var p in result)
//    Console.WriteLine(p); 
//#endregion
//-----------------------
//#region problem3
//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

//var result = Arr.Where((x, i) => x.Length < i);

//foreach (var x in result)
//	Console.WriteLine(x); 
//#endregion
//-----------------------
//#region problem1 element
//using day10_G01;

//var result = ListGenerators.ProductList
//	.First(p => p.UnitsInStock == 0);

//Console.WriteLine(result); 
//#endregion
//--------------
//#region problem2
//using day10_G01;

//var result = ListGenerators.ProductList
//	.FirstOrDefault(p => p.UnitPrice > 1000);

//Console.WriteLine(result); 
//#endregion
//-----------------
//#region problem3
//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//var result = Arr.Where(x => x > 5).ElementAt(1);

//Console.WriteLine(result); 
//#endregion
//-----------------------
//#region problem1 aggregate
//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//var result = Arr.Count(x => x % 2 != 0);

//Console.WriteLine(result); 
//#endregion
//----------------------
//#region problem2
//using day10_G01;

//var result = ListGenerators.CustomerList
//    .Select(c => new
//    {
//        c.Name,
//        OrdersCount = c.Orders.Count()
//    });

//foreach (var item in result)
//    Console.WriteLine($"{item.Name} : {item.OrdersCount}"); 
//#endregion
//----------------
//#region problem3
//using day10_G01;

//var result = ListGenerators.ProductList
//    .GroupBy(p => p.Category)
//    .Select(g => new
//    {
//        Category = g.Key,
//        ProductsCount = g.Count()
//    });

//foreach (var item in result)
//    Console.WriteLine($"{item.Category} : {item.ProductsCount}"); 
//#endregion
//-------------------------
//#region problem4
//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//var result = Arr.Sum();

//Console.WriteLine(result); 
//#endregion
//-----------------
//#region problem1 ordering
//using day10_G01;

//var result = ListGenerators.ProductList
//    .OrderBy(p => p.ProductName);

//foreach (var p in result)
//    Console.WriteLine(p); 
//#endregion
//-----------------
//#region problem2
//string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

//var result = Arr.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);

//foreach (var x in result)
//	Console.WriteLine(x); 
//#endregion
//-------------------
//#region problem3
//using day10_G01;

//var result = ListGenerators.ProductList
//    .OrderByDescending(p => p.UnitsInStock);

//foreach (var p in result)
//    Console.WriteLine(p); 
//#endregion
//----------------
//#region problem4
//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

//var result = Arr
//    .OrderBy(x => x.Length)
//    .ThenBy(x => x);

//foreach (var x in result)
//    Console.WriteLine(x); 
//#endregion
//-----------------------
//#region problem5
//string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

//var result = words
//    .OrderBy(x => x.Length)
//    .ThenBy(x => x, StringComparer.OrdinalIgnoreCase);

//foreach (var x in result)
//    Console.WriteLine(x); 
//#endregion
//----------------------
//#region problem6
//using day10_G01;

//var result = ListGenerators.ProductList
//    .OrderBy(p => p.Category)
//    .ThenByDescending(p => p.UnitPrice);

//foreach (var p in result)
//    Console.WriteLine(p); 
//#endregion
//------------------------
//#region problem7
//string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

//var result = Arr
//    .OrderBy(x => x.Length)
//    .ThenByDescending(x => x, StringComparer.OrdinalIgnoreCase);

//foreach (var x in result)
//    Console.WriteLine(x); 
//#endregion
//-------------------------
//#region problem8
//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

//var result = Arr
//    .Where(x => x.Length > 1 && x[1] == 'i')
//    .Reverse();

//foreach (var x in result)
//    Console.WriteLine(x); 
//#endregion
//----------------
//#region problem1 transformation
//using day10_G01;

//var result = ListGenerators.ProductList
//    .Select(p => p.ProductName);

//foreach (var name in result)
//    Console.WriteLine(name); 
//#endregion
//-----------------------
//#region problem2
//string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

//var result = words.Select(w => new
//{
//    Upper = w.ToUpper(),
//    Lower = w.ToLower()
//});

//foreach (var word in result)
//    Console.WriteLine($"{word.Upper} - {word.Lower}"); 
//#endregion
//-------------------------
//#region pronlem3
//using day10_G01;

//var result = ListGenerators.ProductList
//    .Select(p => new
//    {
//        p.ProductName,
//        p.Category,
//        Price = p.UnitPrice
//    });

//foreach (var p in result)
//    Console.WriteLine($"{p.ProductName} - {p.Category} - {p.Price}"); 
//#endregion
//---------------------
//#region problem4
//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//var result = Arr.Select((number, index) => new
//{
//    Number = number,
//    InPlace = number == index
//});

//foreach (var item in result)
//    Console.WriteLine($"{item.Number}: {item.InPlace}"); 
//#endregion
//------------------------
//#region problem5
//int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
//int[] numbersB = { 1, 3, 5, 7, 8 };

//var result = from a in numbersA
//             from b in numbersB
//             where a < b
//             select new { a, b };

//foreach (var pair in result)
//    Console.WriteLine($"{pair.a} is less than {pair.b}"); 
//#endregion
//---------------------
//#region problem6
//using day10_G01;

//var result = ListGenerators.CustomerList
//    .SelectMany(c => c.Orders)
//    .Where(o => o.Total < 500.00);

//foreach (var order in result)
//    Console.WriteLine(order); 
//#endregion
//------------------------

//#region problem7
//using day10_G01;

//var result = ListGenerators.CustomerList
//    .SelectMany(c => c.Orders)
//    .Where(o => o.OrderDate.Year >= 1998);

//foreach (var order in result)
//    Console.WriteLine(order);
//#endregion
//------------------------
//Aggregate Operators 1->7 مكرر
//#region problem8 
//using day10_G01;

//var result = ListGenerators.ProductList
//    .GroupBy(p => p.Category)
//    .Select(g => new
//    {
//        Category = g.Key,
//        CheapestPrice = g.Min(p => p.UnitPrice)
//    });

//foreach (var item in result)
//    Console.WriteLine($"{item.Category} : {item.CheapestPrice}"); 
//#endregion
//-------------------------
//#region problem9
//using day10_G01;

//var result = from p in ListGenerators.ProductList
//             group p by p.Category into g
//             let minPrice = g.Min(p => p.UnitPrice)
//             from p in g
//             where p.UnitPrice == minPrice
//             select new
//             {
//                 Category = g.Key,
//                 Product = p.ProductName,
//                 Price = p.UnitPrice
//             };

//foreach (var item in result)
//    Console.WriteLine($"{item.Category} : {item.Product} - {item.Price}"); 
//#endregion
//---------------------------
//#region problem10
//string[] words = File.ReadAllLines("dictionary_english.txt");

//var result = words.Max(w => w.Length);

//Console.WriteLine(result); 
//#endregion
//-----------------------
//#region problem11
//using day10_G01;

//var result = ListGenerators.ProductList
//    .GroupBy(p => p.Category)
//    .Select(g => new
//    {
//        Category = g.Key,
//        MostExpensivePrice = g.Max(p => p.UnitPrice)
//    });

//foreach (var item in result)
//    Console.WriteLine($"{item.Category} : {item.MostExpensivePrice}"); 
//#endregion
//---------------------------
//#region problem12
//using day10_G01;

//var result = from p in ListGenerators.ProductList
//             group p by p.Category into g
//             let maxPrice = g.Max(p => p.UnitPrice)
//             from p in g
//             where p.UnitPrice == maxPrice
//             select new
//             {
//                 Category = g.Key,
//                 Product = p.ProductName,
//                 Price = p.UnitPrice
//             };

//foreach (var item in result)
//    Console.WriteLine($"{item.Category} : {item.Product} - {item.Price}"); 
//#endregion
//-------------------------
//#region problem14
//using day10_G01;

//var result = ListGenerators.ProductList
//    .GroupBy(p => p.Category)
//    .Select(g => new
//    {
//        Category = g.Key,
//        AveragePrice = g.Average(p => p.UnitPrice)
//    });

//foreach (var item in result)
//    Console.WriteLine($"{item.Category} : {item.AveragePrice}"); 
//#endregion
//---------------------
//Ordering Operators مكررين
//-------------
//#region problem1 partitioning
//using day10_G01;

//var result = ListGenerators.CustomerList
//    .Where(c => c.Address == "Washington")
//    .SelectMany(c => c.Orders)
//    .Take(3);

//foreach (var order in result)
//    Console.WriteLine(order); 
//#endregion
//-------------------
//#region problem2
//using day10_G01;

//var result = ListGenerators.CustomerList
//    .Where(c => c.Address == "Washington")
//    .SelectMany(c => c.Orders)
//    .Skip(2);

//foreach (var order in result)
//    Console.WriteLine(order); 
//#endregion
//--------------
//#region problem3
//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//var result = numbers.TakeWhile((number, index) => number >= index);

//foreach (var number in result)
//	Console.WriteLine(number); 
//#endregion
//----------------
//#region problem4
//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//var result = numbers.SkipWhile(number => number % 3 != 0);

//foreach (var number in result)
//    Console.WriteLine(number); 
//#endregion
//---------------
//#region problem5
//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//var result = numbers.SkipWhile((number, index) => number >= index);

//foreach (var number in result)
//	Console.WriteLine(number); 
//#endregion
//-------------------------
//#region prpblem1 quantifiers
//using day10_G01;

//var result = ListGenerators.ProductList
//    .GroupBy(p => p.Category)
//    .Where(g => g.Any(p => p.UnitsInStock == 0));

//foreach (var group in result)
//{
//    Console.WriteLine(group.Key);

//    foreach (var p in group)
//        Console.WriteLine(p);
//} 
//#endregion
//------------------
using day10_G01;

var result = ListGenerators.ProductList
    .GroupBy(p => p.Category)
    .Where(g => g.All(p => p.UnitsInStock > 0));

foreach (var group in result)
{
    Console.WriteLine(group.Key);

    foreach (var p in group)
        Console.WriteLine(p);
}