Console.Clear();
Console.Write("Введите 1-ое число ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-ое число ");
int c = int.Parse(Console.ReadLine()!);
if (a > b || a > c)
    Console.WriteLine(a);
else if (b > a || b > c)
    Console.WriteLine(b); 
else
    Console.WriteLine("c");