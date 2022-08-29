/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой
строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(10);
        }
    }
    return matrix;
}

void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] SortArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxPosition]) maxPosition = k;
            }
            int temporery = array[i, j];
            array[i, j] = array[i, maxPosition];
            array[i, maxPosition] = temporery;
        }
    }
    return array;
}

int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);

Console.WriteLine("Отсортированный массив:");

int[,] sortMatrix = SortArray(resultMatrix);
PrintArray(sortMatrix);