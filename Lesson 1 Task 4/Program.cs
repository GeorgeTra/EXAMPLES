// 4. Найти максимальное из трех чисел

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}
    Console.WriteLine(max);
