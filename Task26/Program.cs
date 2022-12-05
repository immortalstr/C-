﻿int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}
double[] ArithmeticMean(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    for (int i = 0; i < average.Length; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double summaArithmeticMean = 0;
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                summaArithmeticMean += matrix[k, i];
                average[i] = Math.Round(summaArithmeticMean / matrix.GetLength(0), 2);
            }
        }
    }
    return average;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i],4} ");
        else Console.Write($"{arr[i],4}");

    }
    Console.Write(" ] Среднее арифметическое каждого столбца");
}


int[,] creatMatrixRndInt = CreateMatrixRndInt(5, 5, 1, 5);
PrintMatrix(creatMatrixRndInt);
ArithmeticMean(creatMatrixRndInt);
double[] aver = ArithmeticMean(creatMatrixRndInt);
Console.WriteLine();
PrintArray(aver);
