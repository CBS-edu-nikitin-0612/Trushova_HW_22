// See https://aka.ms/new-console-template for more information
using Task3;//без явного указания не работает программа, тк не видит другие классы

Console.WriteLine("Hello, Teacher!");

//Создание словаря
MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
myDictionary.Add("книга", "book");
myDictionary.Add("ручка", "pen");
myDictionary.Add("солнце", "sun");
myDictionary.Add("яблоко", "apple");
myDictionary.Add("стол", "table");

//Количество пар слов в словаре
Console.WriteLine(myDictionary.Count);

try
{
    //Вывод на экран переводов заданных слов
    int index = 3;
    Console.WriteLine($"{index + 1}-ая пара слов в словаре: {myDictionary[index].Key} - {myDictionary[index].Value}");
    string word = "солнце";
    Console.WriteLine($"Слово {word} по-английски будет {myDictionary[word]}");
    word = "ручка";
    Console.WriteLine($"Слово {word} по-английски будет {myDictionary[word]}");
    word = "кучка";
    Console.WriteLine($"Слово {word} по-английски будет {myDictionary[word]}");
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message.ToString());
    Console.ForegroundColor = ConsoleColor.Gray;
}