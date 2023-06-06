// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateTextArray(int size)
{
    string[] textArr = new string[size];

    for (int i = 0; i < textArr.Length; i++)
    {
        Console.WriteLine("Введите элемент массива.");
        textArr[i] = Console.ReadLine()!;
    }
    return textArr;
}
string[] NewTextArray(string[] txtArr)
{
    int newSize = 0;
    string[] newTxtArr = new string[newSize];
    int n = 0;
    for (int i = 0; i < txtArr.Length; i++)
    {
        if (txtArr[i].Length <= 3)
        {
            newSize++;
            Array.Resize(ref newTxtArr, newSize);
            newTxtArr[n] = txtArr[i];
            n++;
        }
    }
    return newTxtArr;
}

string[] textArray = CreateTextArray(5);
string[] newTextArray = NewTextArray(textArray);
Console.WriteLine($"[{string.Join(", ", textArray)}] -> [{string.Join(", ", newTextArray)}]");