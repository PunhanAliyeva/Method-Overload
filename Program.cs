namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 23, 34, 12, 7,45, 67, 56, 78 };
            Console.WriteLine(Min(num));
        }
            public static int Min(int[] num)
            {
                int min = num[0];
                for (int i = 0; i < num.Length; i++)
                    if (min > num[i])
                    {
                        min = num[i];
                    }
                return min;

            }
        }
    }