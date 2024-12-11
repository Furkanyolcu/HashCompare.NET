namespace HashingApp
{
    public class EichHashing : GenericBuild
    {
        public override void Hash(int[] array)
        {
            int[] hashTable = new int[1213];
            int[] next = new int[1213];

            // Hash ve next tablolarını başlangıç değerleriyle dolduruyoruz
            for (int i = 0; i < 1213; i++)
            {
                StepCount++; // Adım sayacını artırıyoruz.

                hashTable[i] = 0;
                next[i] = -1;
            }

            for (int i = 0; i < array.Length; i++)
            {
                StepCount++;
                int key = array[i];
                int hash = key % 1213;

                if (hashTable[hash] == 0)
                {
                    // Eğer boş yer varsa, doğrudan ekle
                    hashTable[hash] = key;
                }
                else
                {
                    CollisionCount++; // Çakışma sayacını artır

                    // Bağımsız zincirleme: çakışma varsa, dış zincirleme kullanarak ekle
                    int newHash = FindNextFreeSlot(hashTable);
                    hashTable[newHash] = key;

                    // Bağımsız dış zincir oluşturuyoruz
                    next[newHash] = hash;
                }
            }

            // Hash tablosunu ekrana yazdır
            DisplayTable(hashTable);
        }

        // Boş bir slot bulma fonksiyonu
        private int FindNextFreeSlot(int[] hashTable)
        {
            for (int i = 0; i < hashTable.Length; i++)
            {
                if (hashTable[i] == 0)
                    return i;
            }
            return -1; // Eğer boş yer yoksa -1 dön
        }
    }
}
