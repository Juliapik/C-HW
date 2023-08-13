// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
string printNumbers(int a, int b)
{
    if (a == b)
        return $"{b}";
    return $"{b}, " + printNumbers(a, b - 1);
}


Console.Clear();
int m = 1;
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(printNumbers(m, n));
