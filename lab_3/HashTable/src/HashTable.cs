namespace HashTable.src
{
    class HashTable<K, V>
    {
        private int hash_size { set; get; }
        HashNode<K, V>? []hash_table;

        public HashTable(int _hash_size)
        {
            hash_size = _hash_size;
            hash_table = new HashNode<K, V>[hash_size];
        }
        public int Hash(string keys)
        {
            int key = 0;
            foreach (var item in keys)
            {
                key += item;
            }
            key %= hash_size;
            return key;
        }
        
    }
}