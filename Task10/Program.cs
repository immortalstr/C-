Console.Write("Введите точку ХА: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку ХВ: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку УВ: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int ya, int xb, int yb)
{
    double xc = (xa - xb) * (xa - xb);
    double yc = (ya - yb) * (ya - yb);
    double result = Math.Sqrt(xc + yc);
    return result;
}

double res = Distance(xa, ya, xb, yb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);

Console.WriteLine(resRound);