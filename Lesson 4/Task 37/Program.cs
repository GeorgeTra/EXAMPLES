// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillAndPrintArray (int[] array, int Min, int Max)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {

        array[i] = rnd.Next(0, 1000);
        Console.Write($"{array[i]} ");
    }
}

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

int ColNumber(int[] array)
{
     int number = 0;
     for (int i = 0; i < array.Length; i++)
     {
         if(array[i] > 9 && array[i] < 100)
            number++;
     }
     return number;
}

int[] array = new int[123];

FillAndPrintArray(array, 0, 1000);

(int chet, int nechet) = IsChet(array);
Console.WriteLine($"Четных чисел {chet}, нечетных чисел {nechet}");

Console.WriteLine($"Количество эцифр в диапазоне [10,99] {ColNumber(array)}");


