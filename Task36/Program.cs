// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях
void InputArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 11); 
}
void SearchSum(int[] array) 
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
        sum += array[i];
    Console.WriteLine($"Сумма элементов на нечетных позициях равна: {sum}");
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array); 
Console.WriteLine($"[{string.Join(", ", array)}]"); 
SearchSum(array); 