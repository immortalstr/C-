Console.Clear();

Console.WriteLine($"Ввведите числа через запятую, например 0, 7, 8, -2, -2 ");
string numbers = Console.ReadLine();

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

void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine($"]");
}

int PositiveNumbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
    }
    return counter;
}

string[] StrNumbers = Separation(numbers);
int[] array1 = ConVertation(StrNumbers);

Separation(numbers);
Console.WriteLine($"Числа преобразованны в массив");
PrintArray(array1);
Console.WriteLine($"Колличество чисел больше нуля = {PositiveNumbers(array1)}");

// Console.WriteLine($"Ввведите колличество числе которые собираетесь вводить");
// int length = Convert.ToInt32(Console.ReadLine());
// int [] array1 = ReadNumbers(length);

// int [] ReadNumbers(int size)
// {
//     int[] array2 = new int[size];
//     int i = 0;
//     while (i < size)
//     {
//         Console.WriteLine($"Ввведите число");
//         array2[i] = Convert.ToInt32(Console.ReadLine());
//         i++;
//     }
//     return array2;
// }

// int[] array1 = Array.ConvertAll(StrNumbers, s => int.Parse(s));