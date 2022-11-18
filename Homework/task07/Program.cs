// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число в диапазоне от 1 до 7: ");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DayofTheWeek(number) ? "Да" : "Нет");

bool DayofTheWeek(int num)
{
    return (num == 6) || (num == 7);
}