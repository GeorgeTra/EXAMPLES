// 56. Написать программу, которая обменивает элементы первой строки и последней строки.

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
}

void ChangeFirstWithLast(int[,] array)
{
    int index1 = array.GetLength;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        
    }

}

int[,] workArray = new int[5, 3];

FillTwoDimensionalArray(workArray, 0, 9);
PrintTwoDimensionalArray(workArray);