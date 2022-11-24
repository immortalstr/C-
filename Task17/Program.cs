// 32 Написать программу замену элементов массива на противоположные

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
void PrintArray1(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]*(-1)} ");
    }
}

// void SumArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = -1 * array[i];
//     }
//     Console.WriteLine($"Противоположенные элементы массива = {array[i]}");
// }

RandomArray(array1);
Console.Write("Элементы массива: ");
PrintArray(array1);
Console.WriteLine();
Console.Write("Противоположные элементы массива: ");
PrintArray1(array1);
Console.WriteLine();