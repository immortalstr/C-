// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumNumb(number);

int SumNumb(int num)
{
    return num != 0 ? num % 10 + SumNumb(num / 10) : 0;
}

Console.WriteLine(sum);