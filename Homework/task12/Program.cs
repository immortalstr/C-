// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int Count(int number)
{
    int counter = 0;
    if (number < 0) number = number * -1;
    while (number > 0)
    {
        counter = counter + number % 10;
        number = number / 10;
    }
    return counter;
}

Console.WriteLine($"{num} --> {Count(num)}");