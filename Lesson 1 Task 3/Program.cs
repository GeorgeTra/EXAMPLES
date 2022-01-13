// По заданному номеру дня недели вывести его название

string[] array = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 7)
{
    Console.WriteLine("Неправильно введен номер дня недели");
}
else
    Console.WriteLine(array[number-1]);

