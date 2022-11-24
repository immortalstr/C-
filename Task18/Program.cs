
Console.WriteLine($"Задайте длинну массива, например 12");
int length = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[length];
int num = new Random().Next(0, 9);
Console.WriteLine($"Случайное число равно: {num}");


int[] RandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 9);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SearchNum(int[] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) count++;
    }
    return count;
}

RandomArray(array1);
Console.Write("Элементы массива: ");
PrintArray(array1);
Console.WriteLine($"Случайное число в массиве в колличестве = {SearchNum(array1, num)}");
Console.WriteLine((SearchNum(array1, num) > 0) ? "Массив содержит случайное число" : "Массив не содержит случайное число");
