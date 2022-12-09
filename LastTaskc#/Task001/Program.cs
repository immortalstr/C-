// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.


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

int[,] CreateModifiedMatrix(int[,] matr)
{
    int[,] newmatr = new int[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            newmatr[i, j] = matr[j, i];
        }
    }
    return newmatr;
}

int[,] matrix = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
if (matrix.GetLength(0) != matrix.GetLength(1))
{
    Console.WriteLine("Замена невозможна!!!");
    
}
else
{
    int[,] newmatrix = CreateModifiedMatrix(matrix);
    PrintMatrix(newmatrix);
}
