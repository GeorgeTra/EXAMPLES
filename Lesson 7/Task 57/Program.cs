// 57. Написать программу упорядочивания по убыванию элементов каждой строки двумерного массива.


void FillTwoDimensionalArray(int[,] array, int minNumber, int maxNumber)
{  
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minNumber, maxNumber + 1);
        }
    }
}

void PrintTwoDimensionalArray(int[,] array)
{
    Console.Write("\t");
    for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{j}\t");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++) 
        {
            Console.Write($"{i}\t");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }  
         Console.WriteLine();
}

void SortRow(int[,] array, int indexRow)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1) - 1 - j; k++)
        {
            if (array[indexRow, k] < array[indexRow, k + 1])
            {
                int temp = array[indexRow, k];
                array[indexRow, k] = array[indexRow, k + 1];
                array[indexRow, k + 1] = temp;
            }
        }
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortRow(array, i);
    } 
}

int[,] workArray = new int[6, 7];

FillTwoDimensionalArray(workArray, 0, 9);
PrintTwoDimensionalArray(workArray);
SortArray(workArray);
PrintTwoDimensionalArray(workArray);
