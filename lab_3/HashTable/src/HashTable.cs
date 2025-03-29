namespace HashTable.src
{
    class HashTable<K, V>
    {
        private int hash_size { set; get; }
        private LinkedList<HashNode<K, V>>[] hash_table;

        public HashTable(int _hash_size)
        {
            hash_size = _hash_size; 
            hash_table = new LinkedList<HashNode<K, V>>[hash_size];
            for (int i = 0; i < hash_size; i++)
            {
                hash_table[i] = new LinkedList<HashNode<K, V>>();
            }
        }
        
        public int Hash(K key)
        {
            return Math.Abs(key.GetHashCode()) % hash_size;
        }

        public void Insert(K key, V value)
        {
            int index = Hash(key);
            var bucket = hash_table[index];

            foreach (var node in bucket)
            {
                if (node.Key.Equals(key))
                {
                    Console.WriteLine("This key already has value");
                    return;
                }
            }

            bucket.AddLast(new HashNode<K, V>(key, value)); 
        }

        public V GetValue(K key)
        {
            int index = Hash(key);
            var bucket = hash_table[index];

            foreach (var node in bucket)
            {
                if (node.Key.Equals(key))
                {
                    return node.Value;
                }
            }
            throw new KeyNotFoundException("Value with the specified key wasn't found.");            
        }
        
        public void RewriteValue(K key, V value)
        {
            int index = Hash(key);
            var bucket = hash_table[index];

            foreach (var node in bucket)
            {
                if (node.Key.Equals(key))
                {
                    node.Value = value;
                    return;
                }
            }
            throw new KeyNotFoundException("Value with the specified key wasn't found.");
        }
        
    }
}