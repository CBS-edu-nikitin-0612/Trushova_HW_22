namespace Task4
{
    public class ArrayList
    {
        object[] _array;

        public ArrayList()
        {
            _array = Array.Empty<object>();
        }

        public ArrayList(int length)
        {
            _array = new object[length];
        }

        public void Add(object element)
        {
            _array = _array.Append(element).ToArray();
        }

        public object this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

        public int Count
        {
            get { return _array.Length; }
        }

        public void RemoveAllElements()
        {
            _array = Array.Empty<object>();
            Console.WriteLine($"All cars were removed from base. The base has {this.Count} elements");
        }
    }
}
