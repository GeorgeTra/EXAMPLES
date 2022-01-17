// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

int MyInput(string msg)
{
    Console.Write(msg);
    string answer = Console.ReadLine() ?? string.Empty;
    bool flag = int.TryParse(answer, out int range);
    if (flag)
        return range;
    return-1;
} 

void FillAndPrintArray (int[] array, int Min, int Max)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {

        array[i] = rnd.Next(100, 999);
        Console.Write($"{array[i]} ");
    }
}

/*bool IsNumber(int[] array, int element)
{
    foreach (int el in array)
        if (element == el)
            return true;
    return false;
}*/ 

(int, int) IsChet(int[] array)
{
     int chetnumber = 0;
     int nechet = 0;
     for (int i = 0; i < array.Length; i++)
     {
         if(array[i] % 2 == 0)
            chetnumber++;
        else
            nechet++;
     }
     return(chetnumber, nechet);
}

int[] array = new int[10];

FillAndPrintArray(array, 100, 999);
/*Console.WriteLine();
int answer = MyInput("Введите число: ");
if(answer == -1)
    Console.WriteLine("Неверный ввод ");
    else
    {
    string msg = IsNumber(array, answer) ? "Элемент содержится в массиве" : "Элемента нет";
    Console.WriteLine(msg);
    }*/

(int chet, int nechet) = IsChet(array);
Console.WriteLine($"Четных чисел {chet}, нечетных чисел {nechet}");

