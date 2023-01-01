// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.WriteLine("Укажите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

string?[] array = new string[arraySize];
for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine("Введите строку: ");
    string? numString = Console.ReadLine();
    array[i] = numString;
}


Console.WriteLine("Ваш массив:");
Console.Write("[");
for (int i = 0; i < arraySize; i++)
{
    if (array[i]?.Length <= 3)
    {
        Console.Write(array[i] + ", ");
    }
}
Console.Write("]");