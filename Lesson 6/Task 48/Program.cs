// 48. Показать двумерный массив размером m×n заполненный целыми числами.

void PrintArrayInt(int[] arrayStr)
{
    foreach (var item in arrayStr)
    {
        Console.Write($"{item} ");
    }
}

int[,] CreateArray(int qntRows, int qntColumns, int min, int max)
{
    int[,] array = new int[qntRows, qntColumns];
    Random rnd = new Random();
    for (int i = 0; i < qntRows; i++)
    {    for (int j = 0; i < qntColumns; i++)
        {
        array[i,j] = rnd.Next(min, max);
        }
    }
    return array;
}

