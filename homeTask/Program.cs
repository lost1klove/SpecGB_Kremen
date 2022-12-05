// Задача: Написать программу, которая 
// 1. из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// 2. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите размер массива : ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[arrayLength];

string[] InputArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-й элемент : ");
        array[i] = Console.ReadLine();
        if (array[i].Length == 0)
        {
            Console.Write("Введите значение заново : ");
            array[i] = Console.ReadLine();
        }
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"\"{array[i]}\" ; ");
        else Console.Write($"\"{array[i]}\"");
    }
    Console.Write("]");
}

string[] SortedArray(string[] array)
{
    int count = 0;
    int newCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    string[] newArray = new string[count];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[newCount] = array[i];
            newCount++;
        }
    }
    return newArray;
}


stringArray = InputArray(arrayLength);
string[] newSortedArray = SortedArray(stringArray);
Console.WriteLine();
PrintArray(stringArray);
Console.Write(" => ");
PrintArray(newSortedArray);
Console.WriteLine();
Console.Write("Нажмите любую клавишу для завершения : ");
Console.ReadKey(true);