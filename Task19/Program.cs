Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 10000 || n > 99999)
{
    Console.Write("Вы ошиблись!\nпятизначное число: ");
    n = int.Parse(Console.ReadLine()!);
}
int fir = n;
int sec = 0;
while (n > 0)
{
    sec = sec * 10 + n % 10;
    n /= 10;
}
if (fir == sec)
    Console.WriteLine("да");
else 
    Console.WriteLine("нет");