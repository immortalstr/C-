// int[] array = new int[8];
// int[] array1 = { 1, 2, 3, 5, 7, 1, 2 };
// int[] array2 = new int[4] { 1, 2, 3, 4 };

int[] arr = new int[8];

void RandomArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

RandomArray(arr);
PrintArray(arr);