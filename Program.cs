Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] StartArray = new string[size];
string[] FinalArray = new string[StartArray.Length];
int value = 4;
int j = 0;
Console.WriteLine();

void ElementSelection(string[] array)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент массива: ");
        StartArray[i] = Console.ReadLine();
        if (StartArray[i].Length < value)
        {
            FinalArray[j] = StartArray[i];
            j++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.WriteLine();
    Console.Write("Итоговый массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
}

try
{
    ElementSelection(StartArray);
    PrintArray(FinalArray);
}

catch
{
    Console.Write("Нужно вводить числа!");
}