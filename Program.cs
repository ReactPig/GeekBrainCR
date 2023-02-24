string[] values1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] values2 = new string[values1.Length];
void SecondArrayWithIF(string[] values1, string[] values2)
{
    int count = 0;
    for (int i = 0; i < values1.Length; i++)
    {
    if(values1[i].Length <= 3)
        {
        values2[count] = values1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(values1, values2);
PrintArray(values2);