Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
int result = 1;
while (b > 0)
{
    result *=a;
    b--;
}
Console.WriteLine($"{result}");