

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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

int[] MatrixToArray(int[,] matr)
{
    int[] arr = new int[matr.Length];
    int k = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[k] = matr[i, j];
            k++;
        }
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");

    }
    Console.WriteLine("]");
}

void CountValue(int[] arr)
{
    int count = 1;
    int num = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == arr[i - 1]) count++;
        else
        {
        Console.WriteLine($"{num} встречается {count} раз.");
        count = 1;
        num = arr[i];
        }
    }
    Console.WriteLine($"{num} встречается {count} раз.");
}

int[,] matrix = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = MatrixToArray(matrix);
Array.Sort(array);
PrintArray(array);
CountValue(array);