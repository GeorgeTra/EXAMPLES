// 67. Показать натуральные числа от N до 1, N задано.

int N = 10;
ShowNaturalNumbers(N);
Console.WriteLine();
void ShowNaturalNumbers(int finish)
{   Console.Write($"{finish} ");
    if (finish == 1)
    {
    Console.WriteLine($"{finish} выходим из рекурсии!");
    return;
    }
    Console.WriteLine($"Вызываем функцию {finish - 1}");
    ShowNaturalNumbers(finish - 1);
    Console.WriteLine($"Функция завершилась! {finish}");
}
