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
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}



stringArray = InputArray(arrayLength);
PrintArray(stringArray);