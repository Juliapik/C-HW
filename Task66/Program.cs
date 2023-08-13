// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int summNumbers(int a, int b)
{
    if (a == b)
        return b;
    return summNumbers(a, b - 1) + b;
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(summNumbers(m, n));
