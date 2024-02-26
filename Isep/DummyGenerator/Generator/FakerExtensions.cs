using Bogus;

namespace DummyGenerator.Generator
{
    public static class FakerExtensions
    {
        public static T PickRandomWithRatio<T>(this Faker faker, T[] array, int[] ratios)
        {
            if (array.Length != ratios.Length || array.Length == 0)
            {
                throw new ArgumentException("Array and ratios must have the same non-zero length");
            }

            int totalWeight = ratios.Sum();
            int randomNumber = faker.Random.Number(1, totalWeight);

            int cumulativeWeight = 0;
            for (int i = 0; i < array.Length; i++)
            {
                cumulativeWeight += ratios[i];
                if (randomNumber <= cumulativeWeight)
                {
                    return array[i];
                }
            }

            // This should not happen, but just in case
            return array.Last();
        }
    }
}
