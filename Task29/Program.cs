//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
Console.Write("Введите восьмизначое число: ");
int number = int.Parse(Console.ReadLine()!);
int[] array = new int[8];
for (int i = 7; i >= 0; i--)
{
    array[i] = number % 10;
    number /= 10;
}

Console.WriteLine($"Результат: [{string.Join(", ", array)}]");