// See https://aka.ms/new-console-template for more information
using Task2; 

//Создание автопарка
CarCollection<Car> cars = new CarCollection<Car>();
cars.Add(new Car(name: "bmw", year: 2022));
cars.Add(new Car(name: "audi", year: 2013));
cars.Add(new Car(name: "mercedes", year: 2017));
cars.Add(new Car(name: "hyundai", year: 2014));
cars.Add(new Car(name: "opel", year: 2021));
cars.Add(new Car(name: "geely", year: 2020));

//Вывод на экран информации о всех машинах
Console.WriteLine($"The base has {cars.Count} elements:");
for (int i = 0; i < cars.Count; i++)
{
    Console.WriteLine($"Car {cars[i].Name} of {cars[i].Year} year");
}

//Удаление всех машин из автопарка
cars.RemoveAllElements();

