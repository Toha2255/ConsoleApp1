
namespace AlgoTrening
{
    public class TrainingClass
    {
        public static void Main()
        {
            Console.WriteLine($"Answer = {TrainingMethod()}");
        }
        public static int TrainingMethod()
        {
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int result = 0;
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
