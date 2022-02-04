// 65. Спирально заполнить двумерный массив.

int[,] array = new int[4, 4];
int currentElement = 1;
SpiralFillArray(array);
PrintTwoDimensionalArray(array);


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

void FillHorizontalLine(int[,] array, int index, int start, int end, int direction)
{
    for (int i = start; i < end; i += direction)
    {
        array[index, i] = currentElement++;
    }
}

void FillVerticalLine(int[,] array, int index, int start, int end, int direction)
{
    for (int i = start; i < end; i += direction)
    {
        array[index, i] = currentElement++;
    }
}

void SpiralFillArray(int[,] array)
{
    int count = 1;
    int curRowIndex = 0;
    int startRowIndex = 0;
    int endRowIndex = array.GetLength(1);
    int direction = 1;
    // while (currentElement < array.GetLength(0) * array.GetLength(1))
    {
        FillHorizontalLine(array, curRowIndex, startRowIndex, endRowIndex, direction);
        startRowIndex++;
        FillVerticalLine(array, endRowIndex - 1, startRowIndex, endRowIndex, direction);
        FillHorizontalLine(array, endRowIndex, endRowIndex - 1, startRowIndex, direction*(-1));
    }
}


