using System;

namespace HashingApp
{
    public class MyHashing : GenericBuild
    {
        private int tableSize = 1213;
        private int[] hashTable;

        public override void Hash(int[] array)
        {
            hashTable = new int[tableSize];

            for (int i = 0; i < hashTable.Length; i++)
            {
                hashTable[i] = -1; 
            }

            foreach (int key in array)
            {
                StepCount++; 

                int hashIndex = FirstHash(key); 
                int originalIndex = hashIndex;

                if (hashTable[hashIndex] == -1)
                {
                    hashTable[hashIndex] = key;
                }
                else
                {
                    CollisionCount++; 

                    int i = 1;
                    while (hashTable[hashIndex] != -1)
                    {
                        StepCount++; 
                        hashIndex = (originalIndex + i * SecondHash(key)) % tableSize; 
                        i++;
                    }
                    hashTable[hashIndex] = key;
                }
            }
            DisplayTable(hashTable);
        }

        private int FirstHash(int key)
        {
            return key % tableSize;
        }

        private int SecondHash(int key)
        {
            return 1 + (key % (tableSize - 1));
        }
    }
}
