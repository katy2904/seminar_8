/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.WriteLine("Размер первой матрицы (строк, столбцов): ");
int rowsFirstMatrix = Convert.ToInt32(Console.ReadLine());
int columnsFirstMatrix = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Размер второй матрицы(строк, столбцов): ");
int rowsSecondMatrix = Convert.ToInt32(Console.ReadLine());
int columnsSecondMatrix = Convert.ToInt32(Console.ReadLine());

if(columnsFirstMatrix != rowsSecondMatrix)
{
    Console.WriteLine("Матрицы перемножить нельзя, т.к. количество столбцов первой матрицы"
                    +" не равно количеству строк второй матрицы");
    return;
}

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

int[,] firstArray = GetArray(rowsFirstMatrix, columnsFirstMatrix);

int[,] secondArray = GetArray(rowsSecondMatrix, columnsSecondMatrix);

Console.WriteLine("Матрица 1:");
PrintArray(firstArray);

Console.WriteLine();

Console.WriteLine("Матрица 2:");
PrintArray(secondArray);

Console.WriteLine();

Console.WriteLine("Произведение двух массивов:");

int[,] resultArray = new int[rowsFirstMatrix, columnsSecondMatrix];

for (int i = 0; i < rowsFirstMatrix; i++)
{
    for (int j = 0; j < columnsSecondMatrix; j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < columnsFirstMatrix; k++)
        {
          resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
        }
    }
}

PrintArray(resultArray);