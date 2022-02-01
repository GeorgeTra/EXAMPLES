// 72. Написать программу возведения числа А в целую степень B.

double PowerNumber(double value, int power)
{
    if (power == 0) return 1;
    return value * PowerNumber(value, power - 1);
}

double result = PowerNumber(4, 3);
Console.WriteLine(result);
