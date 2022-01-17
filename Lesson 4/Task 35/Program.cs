// 35. Определить, присутствует ли в заданном массиве некоторое число

int MyInput(string msg)
{
    Console.Write(msg);
    string answer = Console.ReadLine() ?? string.Empty;
    bool flag = int.TryParse(answer, out int range);
    if (flag)
        return range;
    return-1;
} 

void FillAndPrintArray (int[] array, int Min, int Max)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {

        array[i] = rnd.Next(1, 100);
        Console.Write($"{array[i]} ");
    }
}

bool IsNumber(int[] array, int element)
{
    foreach (int el in array)
        if (element == el)
            return true;
    return false;
} 

int[] array = new int[10];
Console.WriteLine();

FillAndPrintArray(array, 0, 10);

int answer = MyInput("Введите число: ");
if(answer == -1)
    Console.WriteLine("Неверный ввод ");
    else
    {
    string msg = IsNumber(array, answer) ? "Элемент содержится в массиве" : "Элемента нет";
    Console.WriteLine(msg);
    }


