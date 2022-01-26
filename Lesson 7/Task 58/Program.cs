// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы, 
// или сообщить, что это невозможно (в случае, если матрица не квадратная).

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

int[,] ChangeRowColumn(int [,] array)
{
    int[,] resultChangeMassive = new int[array.GetLength(1),array.GetLength(0)];
        for(int i = 0; i < array.GetLength(0); i++)
        {
           for (int j = 0; j < array.GetLength(1); j++) 
           {
               resultChangeMassive[j, i] = array[i, j];
           }
        }
        return resultChangeMassive;
}

int[,] ChangeRowColumn2(int [,] array)
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
    return array;
}

int[,] workArray = new int[4, 4];
if (workArray.GetLength(0) != workArray.GetLength(1))
{
    Console.WriteLine("Массив не квадратный!");
    Environment.Exit(1);
}

FillTwoDimensionalArray(workArray, 0, 9);
PrintTwoDimensionalArray(workArray);
var resultChangeMassive = ChangeRowColumn2(workArray);
PrintTwoDimensionalArray(resultChangeMassive);