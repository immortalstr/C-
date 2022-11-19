// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите точку ХА: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку ZA: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку УВ: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку ХВ: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку ZВ: ");
int zb = Convert.ToInt32(Console.ReadLine());


double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double xc = (xa - xb) * (xa - xb);
    double yc = (ya - yb) * (ya - yb);
    double zc = (za - zb) * (za - zb);
    double result = Math.Sqrt(xc + yc + zc);
    return result;
}

double res = Distance(xa, ya, za, xb, yb, zb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);

Console.WriteLine($" A ({xa}, {ya}, {za}); B ({xb}, {yb}, {zb}) --> {resRound}");