﻿// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


Console.Clear();
Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1) Console.WriteLine("Понедельник");
else if (day == 2) Console.WriteLine("Вторник");
else if (day == 3) Console.WriteLine("Среда");
else if (day == 4) Console.WriteLine("Четверг");
else if (day == 5) Console.WriteLine("Пятница");
else if (day == 6) Console.WriteLine("Суббота");
else if (day == 7) Console.WriteLine("Воскресенье");
else Console.WriteLine("Такого дня недели нет");