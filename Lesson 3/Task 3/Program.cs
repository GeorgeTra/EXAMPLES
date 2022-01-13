// Вид 1
void Method1()
{
    Console.WriteLine("Автор Георгий");
}
Method1();


// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);  
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
     int i = 0;
     while (i < count)
     {
          Console.WriteLine(msg);
          i++;
     }
}
Method21("Текст", count: 4);
Method21(count: 4, msg: "новый текст");

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);




// Вид 4
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
         result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);



