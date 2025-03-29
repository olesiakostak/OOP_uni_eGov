namespace HashTable.src
{
    class HashNode<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
        public HashNode<K, V>? Next { get; set; }

        public HashNode(K _key, V _value)
        {
            Key = _key;
            Value = _value;
            Next = null;
        }
    }
}