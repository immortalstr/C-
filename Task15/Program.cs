Console.Clear();
Console.WriteLine("Введите Число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Count(int num)
{
    int counter = 1;
    for (int i = 1; i <= num; i++)
    {
        counter = counter * i;
    }
    return counter;
}

int count = Count(number);

Console.WriteLine($"{number} --> {count}");
