// 66. Показать натуральные числа от 1 до N, N задано.

int N = 10;
ShowNaturalNumbers(1, N);
Console.WriteLine();
void ShowNaturalNumbers(int start, int finish)
{   Console.Write($"{start} ");
    if (start == finish)
    {
    Console.WriteLine($"{start} = {finish} выходим из рекурсии!");
    return;
    }
    Console.WriteLine($"Вызываем функцию {start + 1} , {finish}");
    ShowNaturalNumbers(start + 1, finish);
    Console.WriteLine($"Функция завершилась! {start}");
}