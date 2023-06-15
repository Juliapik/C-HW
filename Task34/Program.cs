// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве
void InputArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); // [-50; 50] 
}
int CountNumbers(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0)
        count ++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array); 
Console.WriteLine($"Массив: [{string.Join(", ", array)}]"); 
Console.WriteLine(CountNumbers(array));