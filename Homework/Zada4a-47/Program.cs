// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

double[,] CreateMatrix(int row, int colum, int min, int max)
{
    double[,] matr = new double[row, colum];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.NextDouble() * (max - min) + min;
            matr[i, j] = Math.Round(matr[i, j], 1);
        }
    }
    return matr;
}

void PrintMatrix(double[,] matr, string str1, string str2)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write($"{str1}");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],5}|");
            else Console.Write($"{matr[i, j],5}");
        }
        Console.WriteLine($"{str2}");
    }
}

double[,] array2D = CreateMatrix(3, 4, -10, 10);
PrintMatrix(array2D, "|", "|");