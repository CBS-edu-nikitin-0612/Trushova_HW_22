namespace Task3
{

    internal class MyDictionary<TKey, TValue>
    {
        private KeyValuePair<TKey, TValue>[] _arrayTKeysTValues;

        public MyDictionary()
        {
            _arrayTKeysTValues = Array.Empty<KeyValuePair<TKey, TValue>>();
        }

        //Добавление одной пары слов
        public void Add(TKey tkey, TValue tvalue)
        {
            _arrayTKeysTValues = _arrayTKeysTValues.Append(new KeyValuePair<TKey, TValue>(tkey, tvalue)).ToArray();
        }

        //Размер словаря
        public int Count
               => _arrayTKeysTValues.Length;

        //Индексатор по ключевому слову TKey
        public TValue this[TKey key]
        {
            get
            {
                int indexKey = IndexOfKey(key, _arrayTKeysTValues);
                if (indexKey >= 0 && indexKey < _arrayTKeysTValues.Length)
                {
                    return _arrayTKeysTValues[indexKey].Value;
                }
                else
                    throw new Exception($"Cлова {key.ToString()} нет в словаре");
            }
        }

        //Индексатор по порядковому номеру слова в словаре
        public Task3.KeyValuePair<TKey, TValue> this[int index]
        {
            get
            {
                if (index >= 0 && index < _arrayTKeysTValues.Length)
                    return _arrayTKeysTValues[index];
                else
                    throw new Exception("Нет такого слова в словаре");
            }
        }

        //Нахождение индекса для выбранного ключевого слова
        private static int IndexOfKey(TKey key, KeyValuePair<TKey, TValue>[] array)
        {
            int i = -1;

            for (int j = 0; j < array.Length; j++)
            {
                if (key != null && key.Equals(array[j].Key))
                    return j;
            }
            return i;
        }

    }
}
