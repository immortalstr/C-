Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайная цифра из отрезка == {number}");

int KillsecondDigit(int num)
{
    int firstDigit = num / 100;
    int threedDigit = num % 10;

    int result = firstDigit * 10 + threedDigit;
    return result;
}

Console.WriteLine(KillsecondDigit(number));