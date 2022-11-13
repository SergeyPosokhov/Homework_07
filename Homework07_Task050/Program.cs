//Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном 
//массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение элемента, т.е какое-нибудь число ");
int value = Convert.ToInt32(Console.ReadLine());


int [,] FillArray (int m, int n)

{
    int[,] array = new int[m,n];
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j]= new Random().Next(0,20);
    }
    return array;
}
Console.WriteLine();
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
int FindIndex (int [,] matrix, int value)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix [i, j] == value)
            {
                Console.WriteLine($"Позиция заданного элемента: [{i};{j}]");
            }
            else if(one == false)
            {
                one = true;
                Console.WriteLine();
                Console.WriteLine($"{value} - такого числа в массиве нет!");
            }
        }
        
    }

    return -1;
}


int[,] array=FillArray(m,n);
PrintArray(array);
FindIndex(array, value);
 