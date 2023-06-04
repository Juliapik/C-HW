Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n < 100)
    Console.WriteLine("Третьей цифры нет");
else
{
    while (n > 999)
    {
        n /= 10;
    }
Console.WriteLine(n % 10);
}