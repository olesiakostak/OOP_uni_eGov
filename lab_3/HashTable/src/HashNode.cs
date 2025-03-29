namespace HashTable.src
{
    class HashNode<K, V>
    {
        public K key { get; set; }
        public V value { get; set; }
        public HashNode<K, V>? Next { get; set; }

        public HashNode(K _key, V _value)
        {
            key = _key;
            value = _value;
            Next = null;
        }
    }
}