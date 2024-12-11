using System;

namespace HashingApp
{
    public class RelischHashing : GenericBuild
    {
        public override void Hash(int[] array)
        {
            int[] hashTable = new int[1213];
            int[] next = new int[1213];

            for (int i = 0; i < 1213; i++)
            {
                hashTable[i] = 0;
                next[i] = -1;
            }

            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                StepCount++;
                int key = array[i];
                int hash = key % 1213;

                if (hashTable[hash] == 0)
                {
                   
                    hashTable[hash] = key;
                }
                else
                {
                    CollisionCount++;

                    //son
                    int j = hash;
                    while (next[j] != -1)
                    {
                        StepCount++;
                        j = next[j];
                    }

                    int newHash = FindRandomFreeSlot(hashTable, rand);
                    hashTable[newHash] = key;
                    next[j] = newHash;
                }
            }

            DisplayTable(hashTable);
        }

        private int FindRandomFreeSlot(int[] hashTable, Random rand)
        {
            while (true)
            {
                int index = rand.Next(hashTable.Length);
                if (hashTable[index] == 0)
                    return index;
            }
        }
    }
}
