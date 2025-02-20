// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Part 15");


var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
Console.Write("List: ");
foreach (var number in numbers)
{
    if (numbers.IndexOf(number) == numbers.Count - 1)
    { Console.Write(number); }
    else
    { Console.Write($"{number} "); }
}
Console.WriteLine();
Console.WriteLine($"Check index of 4 in the list: {numbers.IndexOf(4)}");
