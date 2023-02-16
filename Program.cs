string[] NewStringArrayInput(int size)
{
    string[] newStringArray = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i}-й элемент массива: ");
        newStringArray[i] = Console.ReadLine();
        //Console.WriteLine();
    }

    return newStringArray;
}
