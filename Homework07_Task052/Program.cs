//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
bool one = false;
void Average(int[,] average)
{
    for (int j = 0; j < average.GetLength(1); j++)
    {
        double sum = 0;

        for (int i = 0; i < average.GetLength(0); i++)
        {
            sum += average[i, j];
        }
        if(one == false)
        {
            Console.Write("Среднее африфметическое каждого столбца:");
            one = true;
        }
        Console.Write("{0,5:F1}", sum / average.GetLength(0));
    }
}
int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
Average(array);
Console.WriteLine();

