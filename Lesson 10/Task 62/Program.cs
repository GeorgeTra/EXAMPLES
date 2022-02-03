// 62. В двумерном массиве целых чисел удалить строку и столбец, на пересечении 
// которых расположен наименьший элемент.

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

(int, int) FindIndexOfMinimumNumber(int[,] array)
{
    int minimumNumber = array[0, 0];
    int minRowIndex = 0;
    int minColumnIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minimumNumber)
            {
                minimumNumber = array[i, j];
                minRowIndex = i;
                minColumnIndex = j;
            }
        }
    }
    return (minRowIndex, minColumnIndex);
}

int[,] DeleteRowAndColumnInArray(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    (int rowIndex, int columnIndex) = FindIndexOfMinimumNumber(array);
    int ki = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == rowIndex) continue;
        int kj = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == columnIndex) continue;
            resultArray[ki, kj] = array[i, j];
            kj++;  
        }
        ki++;
    }
    return resultArray;
}

int[,] workArray = new int[3, 4];

FillTwoDimensionalArray(workArray, 0, 5);
PrintTwoDimensionalArray(workArray);
(int minRowIndex, int minColumnIndex) = FindIndexOfMinimumNumber(workArray);
Console.WriteLine($"{minRowIndex}, {minColumnIndex}");
int[,] resultArray = DeleteRowAndColumnInArray(workArray);
PrintTwoDimensionalArray(resultArray);