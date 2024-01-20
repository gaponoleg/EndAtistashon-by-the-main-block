// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] inputArray = {"Hello", "2", "world", ":-)"};
List<string> outputList = new List<string>(); //Создали list типа string

foreach (string str in inputArray) //Цикл который находит из массива строк строку с 3 или менее симвалов
{
    if (str.Length <= 3)
    {
        outputList.Add(str);
    }
}

string[] outputArray = outputList.ToArray(); //Конвертирует list в масcив типа string

Console.WriteLine("\nНовый массив строк (длина <= 3 символов):"); //Выводит новый массив типа string
foreach (string str in outputArray)
{
    Console.Write(str + " ");
}