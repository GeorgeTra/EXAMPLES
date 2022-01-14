// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. 
// Найти сумму положительных/отрицательных элементов массива

void FillAndPrintArray (int[] array, int Min, int Max)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {

        array[i] = rnd.Next(Min, Max + 1);
        Console.Write($"{array[i]} ");
    }
}

int[] Array = new int[12];
FillAndPrintArray (Array, -9, 9);

int SumPositive = 0;
int SumNegative = 0;
for(int i = 0; i < Array.Length; i++)
{
    if (Array[i] >= 0)
    SumPositive += Array[i];
    else
    SumNegative += Array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива равна {SumPositive}");
Console.WriteLine($"Сумма отрицательных элементов массива равна {SumNegative}");