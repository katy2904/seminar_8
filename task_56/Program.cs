/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой
элементов: 1 строка
*/

Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n) // m-строчки matrix.GetLength(0), n-столбцы matrix.GetLength(1)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
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

int[,] array = GetArray(rows, columns);

int minSum = int.MaxValue;
int index = -1;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumRow += array[i, j];
    }
    if (sumRow < minSum)
    {
        minSum = sumRow;
        index = i;
    }
}

PrintArray(array);
Console.WriteLine($"Серока {index} иеет наименьшую сумму элементов");