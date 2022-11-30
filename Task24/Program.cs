Console.Clear();

Console.WriteLine("");
Console.WriteLine("");

// int num = Convert.ToInt32(Console.ReadLine());


int[] CreateArrayInt(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArrayInt(int[] arr, string str1, string str2)
{
    Console.Write($"{str1}");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine($"{str2}");
}

int[] array = CreateArrayInt(5, 1, 10);
PrintArrayInt(array, "[", "]");

int[] CreateReverseArray(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[arr.Length -1 - i];
    }
    return newArray;
}

int[] neaArr = CreateReverseArray(array);
PrintArrayInt(neaArr, "[", "]");