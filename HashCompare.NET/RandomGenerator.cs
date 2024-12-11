using System;

namespace HashingApp
{
    public static class RandomGenerator
    {
        public static int[] GenerateRandomNumbers(int count)
        {
            Random rand = new Random();
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)

            {
                double u1 = 1.0 - rand.NextDouble();
                double u2 = 1.0 - rand.NextDouble();
                double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
                double mean = 5e6;
                double stdDev = 1e6;

                int randomValue = (int)(mean + stdDev * randStdNormal);
                randomValue = Math.Max(0, Math.Min(randomValue, 10000000));

                numbers[i] = randomValue;
            }

            return numbers;
        }
    }
}
