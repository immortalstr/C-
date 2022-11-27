// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



Console.WriteLine();

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(arr[i],1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");

    }
    Console.Write("] Разницу между максимальным и минимальным элементами массива =  ");
}


double DiffMaxMin(double[] arr)
{
    double count = 0;
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
        count = max - min;
    }
    return Math.Round(count,1);
}


double[] array = CreateArrayRndDouble(6, -10, 10);

double difference = DiffMaxMin(array);
PrintArrayDouble(array);
Console.WriteLine($"{difference}");