Console.Clear();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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

int[] array = CreateArrayRndInt(12, -9, 0);
PrintArray(array);

bool FindNumberArray(int[] arr, int numb)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == numb) return true;
    }
    return false;
}

Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("заданное число присутствует в массиве? ");
Console.WriteLine(FindNumberArray(array, number)? "yes" : "no");
