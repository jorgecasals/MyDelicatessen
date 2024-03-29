using MyDelicatessen.LinkedLists;

namespace MyDelicatessen.HashTables
{
    //This hash table is based on a string as a key and int as value.
    //this doesn't take into account collisions and keys that doesn't exist previously in the array.
    public class HashTable
    {
        private LinkedList<(string, int)>[] data;

        public HashTable(int size)
        {
            this.data = new LinkedList<(string, int)>[size];
        }

        private int Hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + key[i] + i) % this.data.Length;
            }
            return hash;
        }

        public void Set(string key, int value)
        {
            int index = Hash(key);
            if (this.data[index] != null)
            {
                this.data[index] = new LinkedList<(string, int)>();
            }
            this.data[index].Append((key, value));
        }

        public int Get(string key)
        {
            int index = Hash(key);

            var list = this.data[index];
            var value = GetValue(key, list);

            return value;
        }

        private int GetValue(string key, LinkedList<(string, int)> list)
        {
            foreach (var pair in list)
            {
                if (pair.key == key)
                    return pair.value;
            }
            return -1;
        }
    }

    public struct HashPair
    {
        public int value;
        public string key;
    }
}