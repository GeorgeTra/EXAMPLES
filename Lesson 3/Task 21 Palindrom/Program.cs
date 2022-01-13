﻿// 21. Программа проверяет пятизначное число на палиндром.


int ReadInt(string msg)
{
    Console.Write(msg);
    string? valueString = Console.ReadLine();
    int valueInt = 0;
try
{
    valueInt = int.Parse(valueString);
    if(!((valueInt > 9999) && (valueInt < 100000))) throw new Exception();
}
catch (System.Exception)
{
    Console.WriteLine("Incorrect input");
    Environment.Exit(1);    
}
return valueInt;    
}

bool IsPoly(int valueInt1)
{
    string valueString = valueInt1.ToString();
    for(int i = 0; i<2; i++)
    {
        if (valueString[i] == valueString[4-i]) continue;
        return false;
    }
    return true;
}
int valueInt1 = ReadInt("Input number 1: ");
if(IsPoly(valueInt1))
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");  
}
