// 63. Сформировать трехмерный массив с не повторяющимися двузначными числами и 
// показать его построчно на экран выводя индексы соответствующего элемента.

void FillThreeDimensionalArray(int[,,] array)
{  
    int start = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = start;
                start++;
            }
        }
    }
}

void PrintThreeDimensionalArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++) 
    {
        Console.WriteLine($"Слой с индексом {k}:");
        Console.Write("\t");
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{j}\t");
        Console.WriteLine();
        for (int i = 0; i < array.GetLength(0); i++) 
            {
                Console.Write($"{i}\t");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j, k]}\t");
                }
                Console.WriteLine();
            }  
            Console.WriteLine();
    }
}

int[,,] array = new int[3, 3, 3];
FillThreeDimensionalArray(array);
PrintThreeDimensionalArray(array);
