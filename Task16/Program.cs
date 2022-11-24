Console.WriteLine($"Задайте длинну массива, например 12");
int length = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[length];
void RandomArray(int[] array)
{
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(0, 9);
        }
}
void PrintArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SumArray(int[] array)
{
    int sumdigits = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sumdigits = sumdigits + array[i];
    }
    Console.WriteLine($"Сумма элементов массива = {sumdigits}");
}

RandomArray(array1);
Console.Write("Элементы массива: ");
PrintArray(array1);
Console.WriteLine();
SumArray(array1);