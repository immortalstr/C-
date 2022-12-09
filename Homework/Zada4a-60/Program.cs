// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] RandomMatrix(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rnd = new Random();
    int num = rnd.Next(min, max + 1);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {   
                matrix[i,j,k] = num;
                num++;

            }
        }
    }
    return matrix;
}


void PrintMatrix(int[,,] matrix, string sep1, string sep2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{sep1}");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 0) Console.Write($"{matrix[i, j, k],5} ({i}, {j}, {k})|");
                else Console.Write($"{matrix[i, j, k],5} ({i}, {j}, {k})");
            }
        }
        Console.WriteLine($"{sep2}");
    }
}

int[,,] array3D = RandomMatrix(2, 2, 2, 10, 99);
PrintMatrix(array3D, "|", "|");
Console.WriteLine("");
