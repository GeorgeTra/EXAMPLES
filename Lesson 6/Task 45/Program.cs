// 45. Показать числа Фибоначчи

/*ulong Fibonacci(ulong number)
{
    if (number == 1 || number == 2)
        {
            return 1;
        }
        return Fibonacci(number - 1) + Fibonacci(number - 2);
}
Console.Clear();
for(ulong i = 1; i <= 20; i++)
Console.Write($"{Fibonacci(i)} ");*/

ulong Fibonacci(ulong number)
{
    if (number == 1 || number == 2) return 1;
    ulong num1 = 1;
    ulong num2 = 1;
    while (number > 2)
        {
            ulong tmp = num1 + num2;
            num1 = num2;
            num2 = tmp;
            --number;
        }
        return num2;
}
Console.Clear();
for(ulong i = 1; i <= 50; i++) Console.Write($"{Fibonacci(i)} ");
Console.WriteLine();
