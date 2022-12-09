Console.Clear();

int[,] CreateMatrix(int row, int colum, int min, int max)
{
    int[,] matr = new int[row, colum];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr, string str1, string str2)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write($"{str1}");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j]} ");
            else Console.Write($"{matr[i, j]}");
        }
        Console.WriteLine($"{str2}");
    }
}

void ReplaceRows(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}

int [,] matr = CreateMatrix(4,4, 1, 10);
PrintMatrix(matr, "[", "]");
Console.WriteLine();
ReplaceRows(matr);
PrintMatrix(matr, "[", "]");
