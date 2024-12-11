using System;
using System.Diagnostics;

namespace HashingApp
{
    public abstract class GenericBuild
    {
        internal string LastIndex;
        internal string LastCollisionCount;

        public int StepCount { get; protected set; } 
        public int CollisionCount { get; protected set; } 
        public TimeSpan ElapsedTime { get; protected set; }

        public abstract void Hash(int[] array);

        public void RunHashing(int[] array)
        {
           
            StepCount = 0;
            CollisionCount = 0; 
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Hash(array);
            stopwatch.Stop(); 
            ElapsedTime = stopwatch.Elapsed; 
        }

        public void DisplayTable(int[] hashTable)
        {
            Console.WriteLine($"{GetType().Name} Hash Tablosu:");
            for (int i = 0; i < hashTable.Length; i++)
            {
                Console.WriteLine($"Index {i}: {hashTable[i]}");
            }
        }
    }
}
