// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

int b = -1;
while (b < 0)
{
    Console.WriteLine("Введите второе натуральное число");
    b = Convert.ToInt32(Console.ReadLine());
    if (b < 0) Console.WriteLine("Введены неверные данные!!!");
}

int Dig(int num1, int num2)
{
    int result = 1;
    for(int i = 0; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}
int dig = Dig(a, b);
Console.WriteLine(dig);
