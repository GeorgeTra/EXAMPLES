// 32. Задать массив из 8 элементов,заполненных нулями и единицами, и вывести их на экран

void FillAndPrintArray (int[] array, int Min, int Max)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {

        array[i] = rnd.Next(Min, Max + 1);
        Console.Write($"{array[i]} ");
    }
}

int[] Array = new int[8];
FillAndPrintArray (Array, 0, 1);

