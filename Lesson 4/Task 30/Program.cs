// 30. Показать кубы чисел, заканчивающихся на четную цифру

int EnterInt(string Text) // Эта функция печатает в консоли нужный текст и возвращает 
                                                      //введенное пользователем число
{
    Console.Write(Text);
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int N = EnterInt("Введите N: ");

Console.WriteLine("Число\t|\tКуб числа");

for (int i = 2; i <= N; i += 2)
{
    Console.WriteLine("{0,5}\t|{1,10}", i, i * i * i);
}
