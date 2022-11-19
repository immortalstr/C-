Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int number = 1;

void Square(int n)
{
while (number < num + 1)
    {
        Console.WriteLine($"{number} --> {number * number}");
        number++;
    }
}
Console.WriteLine($"Квадраты чисел числа {num} равно: ");
Square(num);
