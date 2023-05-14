/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

int GetInitCount()
{
    Console.Write("Введите количество элементов массива: ");
    int elementsCount = Convert.ToInt32(Console.ReadLine());
    string[] Array = new string[elementsCount];
    return elementsCount;
}

void GetInitArray(string?[] InitArray)
{
    for (int i = 0; i < InitArray.Length; i++)
    {
        Console.Write($"\nВведите элемент первичного массива под индексом {i}: ");
        InitArray[i] = Convert.ToString(Console.ReadLine());
    }
}

void PrintInitArray(string[] InitArray)
{
    Console.WriteLine("\nВывод первичного массива:");
    for (int i = 0; i < InitArray.Length - 1; i++)
    {
        Console.Write($"{InitArray[i]}, ");
    }
    Console.Write(InitArray[InitArray.Length - 1]);
}

int GetMax()
{
    Console.WriteLine("\nВведите предельное количество символов: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintResultArray(string[] InitArray, int Max)
{
    Console.WriteLine("\nИтоговый массив элементов с предельным количеством символов: ");
    string[] ResArray = new String[InitArray.Length];
    int count = 0;
    for (int i = 0; i < InitArray.Length; i++)
    {
        if (InitArray[i].Length <= Max)
        {
            ResArray[count] = InitArray[i];
            Console.Write(ResArray[count] + " ");
            count++;
        }
    }
    if (count == 0) Console.Write("Такие элементы отсутствуют");
}

string[] InitArray = new string[GetInitCount()];
GetInitArray(InitArray);
PrintInitArray(InitArray);
int Max = GetMax();
PrintResultArray(InitArray, Max);
