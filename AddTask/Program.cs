// See https://aka.ms/new-console-template for more information
using Task4; //берем напрямую класс из Task4 
using AddTask;
using System.Collections;

/* 
 * Программа запускается.
 * Вверху появилась ошибка CSharpRemoveUnusedValuesCodeFixProvider 
 * Message: System.NullReferenceException : Object reference not set to an instance of an object.
 * (которая при этом не обрабатывается try-catch)
 * Потом пропала и больше не появляется
 */

try
{
    Task4.ArrayList arraylist = new Task4.ArrayList();
    string s = "trololo";
    arraylist.Add(s);
    arraylist.Add(3.14);
    int a = 0;
    arraylist.Add(a);
    arraylist.Add(new MyClass());
    arraylist.Add(new MyStruct());

    //Вывод на экран информации о всех элементах
    Console.WriteLine($"The base has {arraylist.Count} elements:");
    for (int i = 0; i < arraylist.Count; i++)
    {
        Console.WriteLine($"Элемент {i + 1}-й: {arraylist[i]}. Тип {arraylist[i].GetType()}");
    }

    System.Collections.ArrayList arrayListSystem = new System.Collections.ArrayList();    
    arrayListSystem.Add(s);
    arrayListSystem.Add(3.14);
    arrayListSystem.Add(a);
    arrayListSystem.Add(new MyClass());
    arrayListSystem.Add(new MyStruct());

    //Вывод на экран информации о всех элементах System.Collections.ArrayList
    Console.WriteLine($"The System ArrayList has {arrayListSystem.Count} elements:");
    for (int i = 0; i < arrayListSystem.Count; i++)
    {
        Console.WriteLine($"Элемент {i + 1}-й: {arrayListSystem[i]}. Тип {arrayListSystem[i]?.GetType()}");
    }

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Программа выполнилась. Отобразился как пользовательский ArrayList, так и базовый ArrayList.");
    Console.ForegroundColor = ConsoleColor.Gray;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


