int ReadIntFromConsole(string msg)

{
    Console.WriteLine(msg);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int number1 = ReadIntFromConsole("Введите первое число: ");
int number2 = ReadIntFromConsole("Введите второе число: ");

if((number1 == number2 * number2) || (number2 == number1 * number1))
{
    Console.WriteLine("One number is the square amount of the other");
}
else
{
    Console.WriteLine("One number is not the square amount of the other");
}