// Задайте массив вещественных чисел, Найдите разницу между макс. и мин. элементов массива
void InputArray(double[] array)
{
    int end = 30, begin = 10;
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
}
void DiffMinMax(double[] array)
{
double min = array[0];
double max = array[0];
for (int i = 1; i < array.Length; i++)
{
if (array[i] < min)
min = array[i];
if (array[i] > max)
max = array[i];
}
double diff = Math.Round((max - min), 2);
Console.WriteLine($"разница между максимальным и минимальным элементов равна: {diff},");
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
DiffMinMax(array);