// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = 0;

int Rev(int numb)
{
    while (numb != 0)
    {
        num2 = (num2 + (numb % 10)) * 10;
        numb = numb / 10;

    }
    return num2 / 10;
}

if (num1 >= -99999 && num1 <= 99999)
{
    if (Rev(num1) == num1) Console.WriteLine($"{num1} --> ДА!!");
    else Console.WriteLine($"{num1} --> НЕТ!!");
}
else Console.WriteLine("Введите пятизначное число:");
