//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];

double[,] FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().NextDouble() * 10);
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,5:F1}", array[i, j]);
        }
        Console.WriteLine();
    }
}

double[,] arr = FillArray(array);
PrintArray(arr);