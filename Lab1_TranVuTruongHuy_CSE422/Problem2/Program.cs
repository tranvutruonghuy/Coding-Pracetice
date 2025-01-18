namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividend = int.Parse(Console.ReadLine());
            int divisor = int.Parse(Console.ReadLine());
            int result = Divide(dividend, divisor);
            Console.WriteLine(result);
        }
        public static int Divide(int dividend, int divisor)
        {
            if (IsOverflowCase(dividend, divisor))
                return int.MaxValue;

            bool isNegative = IsResultNegative(dividend, divisor);

            long absDividend = Math.Abs((long)dividend);
            long absDivisor = Math.Abs((long)divisor);

            int result = PerformDivision(absDividend, absDivisor);

            return isNegative ? -result : result;
        }

        public static bool IsOverflowCase(int dividend, int divisor)
        {
            return dividend == int.MinValue && divisor == -1;
        }

        public static bool IsResultNegative(int dividend, int divisor)
        {
            return (dividend < 0) ^ (divisor < 0);
        }

        public static int PerformDivision(long absDividend, long absDivisor)
        {
            int result = 0;

            while (absDividend >= absDivisor)
            {
                long temp = absDivisor;
                int multiple = 1;

                while (absDividend >= (temp << 1))
                {
                    temp <<= 1;
                    multiple <<= 1;
                }

                absDividend -= temp;
                result += multiple;
            }

            return result;
        }
    }
}
