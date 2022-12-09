int[,] RandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int num = 1;
    int i = 0;
    int j = 0;
    while (num <= rows * columns)
    {
        matrix[i, j] = num;
        if (i <= j + 1 && i + j < rows - 1)
            j++;
        else if (i < j && i + j >= rows - 1)
            i++;
        else if (i >= j && i + j > rows - 1)
            j--;
        else
            i--;
        ++num;
        
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, string sep1, string sep2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{sep1}");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}|");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine($"{sep2}");
    }
}

int [,] matrix = RandomMatrix(4,4);
PrintMatrix(matrix,"[", "]");

