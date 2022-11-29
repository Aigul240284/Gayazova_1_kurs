Console.Clear();

string[] array = new string[4] { "hello", "2", "world", ";-)" };
string[] shortArray = GetShortArray(array);

PrintArray(array);

Console.Write("  ->  ");
PrintArray(shortArray);

/// <Получение отфильтрованного массива />
string[] GetShortArray(string[] array)
{
    int count = array.Length;
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }

    }
    return newArray;
}

/// <Печать результата />
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] != null) Console.Write($"{array[j]} ");
    }
    Console.Write("]");
}




