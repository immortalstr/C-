// Напишите программуб которая:
// 1. на вход принимает число 
// 2. и выдает его квадрат

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int number = int.Parse(Console.ReadLine());  --- преобразует только строку в int


int square = number * number;

Console.WriteLine($"Квадрат числа {number} равен {square}");

// Для интерполяции строки используется ($"Квадрат числа {number}")