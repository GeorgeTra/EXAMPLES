// 47. Написать программу копирования массива.

void PrintArrayInt(int[] arrayStr)
{
    foreach (var item in arrayStr)
    {
        Console.Write($"{item} ");
    }
}

int[] CreateArray(int number, int min, int max)
{
    int[] array = new int[number];
    Random rnd = new Random();
    for (int i = 0; i < number; i++)
        {
            array[i] = rnd.Next(min, max);
        }
        return array;
}

int[] array1 = CreateArray(10, 1, 100);
PrintArray