void PrintArray(string[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
        Console.Write($"{col[position]}\t");
}

int ArrayLength(string[] array, int maxCountOfChar)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxCountOfChar) count++;
    }
    return count;
}

string[] LessThanArray(string[] originalArray, int maxCountOfChar)
{
    string[] newArray = new string[ArrayLength(originalArray, maxCountOfChar)];
    int count = 0;
    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length <= maxCountOfChar)
        {
            newArray[count] = originalArray[i];
            count++;
        }
    }
    return newArray;
}

string[] myArray = new string[4] { "hello", "2", "world", ":-)" };
Console.WriteLine("Наш массив:");
PrintArray(myArray);
string[] resultArray = LessThanArray(myArray, 3);
Console.WriteLine("\nМассив, включающий лишь элементы с 3 и менее символами:");
PrintArray(resultArray);