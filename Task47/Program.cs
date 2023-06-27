// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void InputMatrix(double[,] matrix) //процедура заполнения двумерного массива
{
    for(int i = 0; i < matrix.GetLength(0); i++) //возвращет кол-во строк
    {
        for(int j = 0; j < matrix.GetLength(1); j++) //возвращает кол-во столбцов
            matrix[i, j] = Math.Round(new Random().NextDouble(), 2); // [-30; 30]
    }
}
void PrintMatrix(double[,] matrix) //процедура вывода двумерного массива на экран
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t"); //\t - табуляция
        
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размеры массива: ");
int [] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);