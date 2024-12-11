namespace HashingApp
{
    using System;
    using System.Collections.Generic;

    public class LichHashing : GenericBuild
    {
        private List<int> overflowArea = new List<int>(); 

        public override void Hash(int[] array)
        {
            int[] hashTable = new int[1213];
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

                    int j = FindNextEmptySlot(hashTable, hash);

                    if (j != -1) 
                    {
                        hashTable[j] = key;
                    }
                    else
                    {
                        overflowArea.Add(key);
                    }
                }
            }

            DisplayTable(hashTable);
            DisplayOverflowArea();
        }

        private int FindNextEmptySlot(int[] hashTable, int startIndex)
        {
            int index = startIndex;
            while (hashTable[index] != 0)
            {
                StepCount++;
                index = (index + 1) % 1213;

                if (index == startIndex)
                {
                    return -1; 
                }
            }
            return index;
        }

        private void DisplayOverflowArea()
        {
            Console.WriteLine("Taşma Alanı:");
            foreach (int item in overflowArea)
            {
                Console.WriteLine(item);
            }
        }
    }
}
