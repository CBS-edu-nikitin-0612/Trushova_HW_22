namespace Task2
{
    internal class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Car()
        {
            Name = "Noname";
            Year = 0;
        }

        public Car(string name, int year)
        {
            Name = name;
            Year = year;
        }
    }
}
