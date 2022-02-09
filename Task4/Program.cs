// See https://aka.ms/new-console-template for more information
using Task4;

ArrayList arraylist = new ArrayList();
arraylist.Add((object)1);
arraylist.Add((object)5);
arraylist.Add((object)4.6);
arraylist.Add((object)6);
arraylist.Add((object)7);
arraylist.Add(3.14);
arraylist.Add(0);


//Вывод на экран информации обо всех элементах
Console.WriteLine($"The base has {arraylist.Count} elements:");
for (int i = 0; i < arraylist.Count; i++)
{
    Console.WriteLine($"Элемент {i+1}-й: {arraylist[i]}. Тип {arraylist[i].GetType()}");
}

//Удаление всех машин из автопарка
arraylist.RemoveAllElements();