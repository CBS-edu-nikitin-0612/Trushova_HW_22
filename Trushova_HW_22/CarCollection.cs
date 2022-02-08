namespace Task2
{
    internal class CarCollection<T> where T : Car
    {
        T[] cars;

        public CarCollection()
        {
            cars = new T[]{};
        }

        public void Add(T car)
        {
            cars = cars.Append(car).ToArray();
        }

        public T this[int index]
        {
             get { return cars[index]; }
             set { cars[index] = value; }
        }

        public int Count
        {
            get { return cars.Length; }
        }

        public void RemoveAllElements()
        {
            cars = Array.Empty<T>();
            Console.WriteLine($"All cars were removed from base. The base has {this.Count} elements");
        }
    }
}
