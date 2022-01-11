Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if((number <= 7) && (number > 0)) 
{
    if (number <= 5)
    {
        Console.WriteLine("Это не выходной день");
    }
    else
    {
    Console.WriteLine("Это выходной день"); 
    }
}

else
{
    
    Console.WriteLine("Такого дня недели нет");
}