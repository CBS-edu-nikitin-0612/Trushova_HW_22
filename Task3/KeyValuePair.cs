namespace Task3
{
    internal class KeyValuePair<TKey, TValue>
    {
        private TKey key;
        private TValue value;

        public KeyValuePair(TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }

        public TKey Key 
        { 
            get { return key; }  
            set { key = value; }
        }

        public TValue Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }
}
