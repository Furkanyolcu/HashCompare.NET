namespace HashingApp
{
    public class LischHashing : GenericBuild
    {
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

                    int j = hash;
                    while (hashTable[j] != 0)
                    {
                        StepCount++; 
                        j = (j + 1) % 1213;
                    }
                    hashTable[j] = key;
                }
            }
            DisplayTable(hashTable);

        }
    }
}
