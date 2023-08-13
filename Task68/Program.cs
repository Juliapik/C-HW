// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Ackermann (int a, int b)
{
    if (a == 0)
    return b + 1;
  else
    if ((a != 0) && (b == 0))
      return Ackermann(a - 1, 1);
    else
      return Ackermann(a - 1, Ackermann (a, b - 1));
}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Ackermann(m, n));