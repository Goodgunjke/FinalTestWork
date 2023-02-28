// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите элементы массива через запятую: ");
string[] array = Console.ReadLine().Split(',');
string[] newArray = new string[array.Length];
int index = 0;
foreach (string str in array)
{
    if (str.Length <= 3)
    {
        newArray[index] = str;
        index++;
    }
}
Array.Resize(ref newArray, index);
Console.WriteLine("Новый массив строк, длина которых меньше или равна 3 символам:");
foreach (string str in newArray)
{
    Console.WriteLine(str);
}
Console.ReadLine();
