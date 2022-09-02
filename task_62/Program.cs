/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

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

// Немного усложнила себе задачку, сделав ввод размера массива с консоли.
Console.WriteLine("Введите размер массива (строки, столбцы)");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int lap = 0;

if (rows <= columns && rows % 2 == 0) lap = rows / 2;
else if (columns < rows && columns % 2 == 0) lap = columns / 2;
else if (rows <= columns && rows % 2 != 0) lap = rows / 2 + 1;
else if (columns < rows && columns % 2 != 0) lap = columns / 2 + 1;

int[,] array = new int[rows, columns];

int number = 1;
int k = 0;

while (k < lap)
{
    for (int i = 0 + k; i < columns - k; i++)
    {
        array[0 + k, i] = number;
        number++;
    }

    if (number > rows * columns) break;

    for (int j = 1 + k; j < rows - k; j++)
    {
        array[j, columns - 1 - k] = number;
        number++;
    }

    if (number > rows * columns) break;

    for (int i = columns - 2 - k; i >= 0 + k; i--)
    {
        array[rows - 1 - k, i] = number;
        number++;
    }

    if (number > rows * columns) break;

    for (int j = rows - 2 - k; j >= 1 + k; j--)
    {
        array[j, 0 + k] = number;
        number++;
    }
    if (number > rows * columns) break;
    k++;
}

PrintArray(array);