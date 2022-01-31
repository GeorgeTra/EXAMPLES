// 60. Составить частотный словарь элементов двумерного массива.

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

bool FindEqualElement (int[] array, int findElement, int countElements)
{
    for (int i = 0; i < countElements; i++)
    {
        if (array[i] == findElement) return true;
    }
    return false;
}

int[] FindDifferentElement(int[] array)
{
    int[] workArray = new int[array.Length];
    int countElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (!FindEqualElement(workArray, array[i], countElements))
        {
            workArray[countElements] = array[i];
            countElements++;
        }
    }
    return CopyArray(workArray, countElements);
}

int[] CopyArray(int[] array, int countElements)
{
    int[] workArray = new int[countElements];
    for (int i = 0; i < countElements; i++)
    {
     workArray[i] = array[i];
    }
    return workArray;
}

int[] CreateOneDimensionArray(int[,] array)
{
    int[] resultArray = new int[array.GetLength(0) * array.GetLength(1)];
    int i = 0;
    foreach (int element in array)
    {
        resultArray[i] = element;
        i++;
    }
    return resultArray;
}

void PrintOneDimensionArray(int[] array)
{
    foreach (int element in array)
    {
        Console.Write($"{element}\t");
    }
Console.WriteLine();
}

int CountUniqueElements(int[] array, int element)
{
    int countElement = 0;
    foreach (int currentElement in array)
    {
        if (currentElement == element) countElement++;
    }
    return countElement;
}

int[,] FindFrequencyElements(int[] foundArray, int[] uniqueElementsArray)
{
    int[,]resultArray = new int [uniqueElementsArray.Length, 2];
    for (int i = 0; i < uniqueElementsArray.Length; i++)
    {
        resultArray[i, 0] = uniqueElementsArray[i];
        resultArray[i, 1] = CountUniqueElements(foundArray, uniqueElementsArray[i]);
    }
    return resultArray;
}

void PrintResult(int[,] array, double countElements)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double frequencyElement = array[i, 1] * 100 / countElements;
        Console.WriteLine
        ($"Число {array[i, 0]} встречается {array[i, 1]} раз. Частота {frequencyElement:N2}%");
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(0) - 1 - i; k++)
        {
            if (array[k, 1] < array[k + 1, 1])
            {
                int temp = array[k, 1];
                array[k, 1] = array[k + 1, 1];
                array[k + 1, 1] = temp;
                int temp2 = array[k, 0];
                array[k, 0] = array[k + 1, 0];
                array[k + 1, 0] = temp2;
            }
        }
    }
}

int[,] workArray = new int[4, 6];
FillTwoDimensionalArray(workArray, 0, 9);
PrintTwoDimensionalArray(workArray);

int[] foundArray = CreateOneDimensionArray(workArray);
PrintOneDimensionArray(foundArray);
int[] uniqueElementsArray = FindDifferentElement(foundArray);
PrintOneDimensionArray(uniqueElementsArray);
int[,] resultArray = FindFrequencyElements(foundArray, uniqueElementsArray);
SortArray(resultArray);
PrintResult(resultArray, foundArray.Length);


