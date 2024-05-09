namespace _6._SoNguyenTo
{
    internal class Program
    {
        public static bool KiemTraSoNguyenTo(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++) {
                if (KiemTraSoNguyenTo(i))
                {
                        Console.Write($"{i}, ");
                }
            }
        }
    }
}