bool[] value1 = {false, true};
bool[] value2 = {false, true};

for(int i = 0; i < value1.Length; i++) 
{
    for(int j = 0; j < value2.Length; j++) 
    {
        Console.WriteLine($"{value1[i]} + {value2[j]} = {!(value1[i] && value2[j])} {(!(value1[i] || !value2[j]))}");     
    }

}

// ¬(X ⋁ Y) = ¬X ⋀ ¬Y
