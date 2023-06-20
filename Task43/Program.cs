//Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнниями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine()!);
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine($"Пересемение в точке: ({x};{y})");
