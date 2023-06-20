// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.Clear();
Console.Write("Введите числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    count++;
}
Console.WriteLine();
Console.WriteLine($"Кол-во значений больше 0 = {count}");