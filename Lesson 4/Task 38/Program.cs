// 38. Найти сумму чисел одномерного массива, стоящих на нечетной позиции

void FillAndPrintArray (int[] array, int Min, int Max)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {

        array[i] = rnd.Next(0, 100);
        Console.Write($"{array[i]} ");
    }
}

int Sum(int[] array)
{
int number = 0;
     for (int i = 1; i < array.Length; i += 2)
     {
            number += array[i];
     }
     return number;
}

int[] array = new int[10];

FillAndPrintArray(array, 0, 10);

Console.WriteLine($"Сумма элементов на нечетных индексах {Sum(array)}");

