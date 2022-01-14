// 31. Задать массив из 8 элементов и вывести их на экран

void FillAndPrintArray (int[] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {

        array[i] = rnd.Next(1, 100);
        Console.Write($"{array[i]} ");
    }
}

int[] Array = new int[8];
FillAndPrintArray (Array);
