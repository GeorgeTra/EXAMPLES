// 25. Найти сумму чисел от 1 до А.

Console.WriteLine("Введите число А: ");                // математикой
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {A} равна {(A + 1) * A / 2}");

int Sum1(int a) // циклом
{
    int s = 0;
    for (int i = 0; i <= a; i++) s += i;
    return s;
}

int Sum2(int a) // математикой
{
    return (a * (a + 1) / 2);
}

int Sum3(int a) // рекурсией
{
    if (a == 1) return 1;
    else return  a + Sum3 (a - 1);
}

int n = 100;

DateTime dt = DateTime.Now;
Console.WriteLine(Sum1(n));
Console.WriteLine($"Sum1 {(DateTime.Now - dt).TotalMilliseconds}ms");

dt = DateTime.Now;
Console.WriteLine(Sum2(n));
Console.WriteLine($"Sum2 {(DateTime.Now - dt).TotalMilliseconds}ms");

dt = DateTime.Now;
Console.WriteLine(Sum3(n));
Console.WriteLine($"Sum3 {(DateTime.Now - dt).TotalMilliseconds}ms");