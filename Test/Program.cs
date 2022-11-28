// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите любые значения через пробел");
string[] array = GetArray();
string[] GetArray()
{
    return Console.ReadLine().Split(" "); // Пользователь задает массив, программа его считывает.
}

string[] result = FindLessThan(array, 3); 
Console.WriteLine($"[{string.Join(" ", array)}] -> [{string.Join(" ", result)}]");

string[] FindLessThan(string[] input, int n)  // Метод, который ищет значения меньше n символов.
{
    string[] output = new string[CountLessThan(input, n)];

    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int n)
{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }

    return count;
}