Console.Clear();
Console.WriteLine("Введите Число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Count(int num)
{
    int counter = 0;
    while (num > 0)
    {
    num = num / 10;
    counter++;
    }
    return counter == 0 ? 1: counter;
}

if (number < 0) number = Math.Abs(number);
int count = Count(number);
Console.WriteLine($"{number} --> {count}");