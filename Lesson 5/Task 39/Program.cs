// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д.

void FillArray (int[] array, int min, int max)
{
    int len = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(min, max);
    }
}       

void PrintArray (int[] array)
{
    int len = array.Length;

    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i],8}");
    }
    Console.WriteLine();
}  

int[] MultElement(int[] array)
{
    int len = array.Length;
    int lenResult = len % 2 == 0 ? len / 2 : len / 2 + 1;
    int[] temp = new int[lenResult];
    for (int i = 0; i < lenResult; i++)
    {
        temp[i] = array[i] * array[len - 1 - i];
    }
    return temp;
}  


int[] array = new int[5];
FillArray(array, 1, 10);
PrintArray(array);
int[] arrResult = MultElement(array);
PrintArray(arrResult);

