/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая
будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.WriteLine("Задайте размер массива(строки, столбцы, глубина);");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int depth = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[rows, columns, depth];

//при заполнении псевдослучайными числами вероятны повторения с тем большей вероятностью, чем больше
//размер задаваемого массива, поэтому ну нет...
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        for (int k = 0; k < array.GetLength(2); k++)
//        {
//            array[i, j, k] = new Random().Next(10, 100);
//        }
//    }
//}

// этот вариант "тупой" но условию задачи отвечает)

if (rows * columns * depth > 90)
{
    Console.WriteLine($"Массив размером {rows}х{columns}х{depth} "
               +"невозможно заполнить двузначными неповторяющимися числами");
    return;
}

int number = 10;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = number;
            number++;
        }
    }
}

void PrintArray(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            for (int k = 0; k < inputMatrix.GetLength(1); k++)
            {
                Console.Write($"{inputMatrix[i, m, k]} ({i},{m},{k})    ");
            }
            Console.WriteLine();
        }
        
    }
}


PrintArray(array);