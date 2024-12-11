namespace HashingApp
{
    public class BeischHashing : GenericBuild
    {
        public override void Hash(int[] array)
        {
            int[] hashTable = new int[1213];
            int[] next = new int[1213];

            for (int i = 0; i < array.Length; i++)
            {
                StepCount++; 
                int key = array[i];
                int hash = key % 1213;

                if (hashTable[hash] == 0)
                {
                    hashTable[hash] = key;
                    next[hash] = -1;
                }
                else
                {
                    CollisionCount++;

                    int j = hash;
                    while (next[j] != -1)
                    {
                        StepCount++;
                        j = next[j];
                    }
                    int newHash = FindNextFreeSlot(hashTable);
                    hashTable[newHash] = key;
                    next[j] = newHash;
                    next[newHash] = -1;
                }
            }
            DisplayTable(hashTable);
        }

        private int FindNextFreeSlot(int[] hashTable)
        {
            for (int i = 0; i < hashTable.Length; i++)
            {
                if (hashTable[i] == 0)
                    return i;
            }
            return -1;
        }
    }
}
