// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

string[] Separation(string num)
{
    char[] separator = { ',', ' ' }; //можно сделать через string[] separator = {", "}
    string[] strlist = num.Split(separator, StringSplitOptions.RemoveEmptyEntries);
    return strlist;
}

int[] ConVertation(string[] strlist)
{
    int[] convertedarray = new int[strlist.Length];
    for (int i = 0; i < strlist.Length; i++)
    {
        convertedarray[i] = Convert.ToInt32(strlist[i]);
    }
    return convertedarray;
}

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

void PrintResult(int[,] matr, int[] array)
{
    if (array[0] >= matr.GetLength(0) || array[1] >= matr.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else Console.WriteLine($"Значение по заданным координатам [{array[0]}, {array[1]}] в двумерном массиве  = {matr[array[0], array[1]]}");
}



int[,] createMatrix = CreateMatrix(3, 4, 0, 10);
PrintMatrix(createMatrix, "[", "]");
Console.WriteLine($"Ввведите позицию через запятую, например 1, 7");
string numbers = Console.ReadLine();
string[] pozition = Separation(numbers);
int[] pozitionInMatrix = ConVertation(pozition);
PrintResult(createMatrix, pozitionInMatrix);



