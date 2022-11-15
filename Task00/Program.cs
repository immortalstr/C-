Console.Clear();

int number = new Random().Next(10, 100);
Console.WriteLine(number);

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine(firstDigit);
// else Console.WriteLine(secondDigit);

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // else return secondDigit;

    // int max = firstDigit > secondDigit ? firstDigit : secondDigit;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");