// Напишите программуб которая:
// 1. на вход принимает число 
// 2. и выдает его квадрат

// Console.WriteLine("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int number = int.Parse(Console.ReadLine());  --- преобразует только строку в int


// int square = number * number;

// Console.WriteLine($"Квадрат числа {number} равен {square}");

// Для интерполяции строки используется ($"Квадрат числа {number}")



// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b)
{
    Console.WriteLine($"Число {a} является квадратом {b}");
}
else
{
    Console.WriteLine($"Число {a} не является квадратом {b}");
}


