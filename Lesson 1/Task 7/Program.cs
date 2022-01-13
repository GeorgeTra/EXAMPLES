// 7. Показать числа от -N до N

Console.WriteLine("Введите число нижнего диапазона: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число верхнего диапазона: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA >= numberB)
{
 Console.WriteLine("Неверный ввод ");   
}

else while (numberA <= numberB)
{
   Console.Write("  " + numberA);
   numberA = numberA + 1;
}