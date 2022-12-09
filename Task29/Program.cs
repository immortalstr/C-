// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void NumbersMToN(int numb1, int numb2)
{
    if (numb1 > numb2)
    {
        Console.Write($"{numb1} ");
        NumbersMToN(numb1 - 1, numb2);
    }
    else if (numb1 < numb2)
    {
        Console.Write($"{numb1} ");
        NumbersMToN(numb1 + 1, numb2);
    }
    else
    {
        Console.Write($"{numb1} ");
    }
}

NumbersMToN(number1, number2);