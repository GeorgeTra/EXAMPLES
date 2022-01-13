// По заданному номеру дня недели вывести его название

Console.WriteLine("Введите номер дня недели: ");
int chislo = Convert.ToInt32(Console.ReadLine());
if (chislo == 1)
    Console.WriteLine("Понедельник");
else if (chislo == 2)
        Console.WriteLine("Вторник");
    else if (chislo == 3)
            Console.WriteLine("Среда");
        else if (chislo == 4)
                Console.WriteLine("Четверг");
            else if (chislo == 5)
                    Console.WriteLine("Пятница");
                else if (chislo == 6)
                        Console.WriteLine("Суббота");
                    else if (chislo == 7)
                            Console.WriteLine("Воскресенье");

