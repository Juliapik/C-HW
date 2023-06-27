// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-30, 31); // [-30; 30]
    }
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        
        Console.WriteLine();
    }
}
void FindNumber (int[,] matrix)
{
Console.Write("Введите номер строки: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца: ");
int col = int.Parse(Console.ReadLine()!);
if (matrix.GetLength(0) >= str && matrix.GetLength(1) >= col)
{
int i = str - 1;
int j = col - 1;
    Console.Write($"{matrix[i, j]}");
}
else
Console.Write("Такого элемента нет");
}
Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
FindNumber(matrix);
