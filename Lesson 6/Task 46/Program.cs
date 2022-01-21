// 46. Написать программу масштабирования фигуры.

Console.WriteLine("Input figure coordinates through spaces: ");
string coordinatesStr = Console.ReadLine();
var coordArray = coordinatesStr.Split(new char[] {',', ' ', '(', ')'}, 
StringSplitOptions.RemoveEmptyEntries);

PrintArray(coordArray);

Console.Write("Input multiplier: ");
int multi = Convert.ToInt32(Console.ReadLine());

int[] result = new int[coordArray.Length]; 
for (int i = 0; i < coordArray.Length; i++)
{
    result[i] = Convert.ToInt32(coordArray[i]);
    result[i] *= multi;
}

PrintArrayInt(result);

void PrintArrayInt(int[] arrayStr)
{
    foreach (var item in arrayStr)
    {
        Console.Write($"{item} ");
    }
}

void PrintArray(string[] arrayStr)
{
    foreach (var item in arrayStr)
    {
        Console.Write($"{item} ");
    }
}

Console.WriteLine();
