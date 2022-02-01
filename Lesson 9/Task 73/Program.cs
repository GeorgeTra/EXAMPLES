// 73. Написать программу, показывающую первые N чисел, для которых каждое 
// следующее равно сумме двух предыдущих. Первые два элемента последовательности 
// задаются пользователем

int EnterInt(string Text)  // Эта функция печатает в консоли нужный текст и возвращает
// число, введенное пользователем.
{
    Console.Write(Text);
    int Number = convert.ToInt32(Console.ReadLine());
    return Number;
}

int startFirst = EnterInt("Введите первое число: ")
int startSecond = EnterInt("Введите второе число: ")

string StringNumbers (int startFirst, int startSecond, int count)
{
    if()
    return $"{startFirst} {startSecond} {StringNumbers(startSecond, 
    startFirst + startSecond";
}