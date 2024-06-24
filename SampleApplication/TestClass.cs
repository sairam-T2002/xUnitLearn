namespace SampleApplication
{
    public class TestClass
    {
        public static int Add(params int[] values )
        {
            return values.Sum();
        }
        public static int Factorial( int value )
        {
            if (value < 0)
            {
                throw new ArgumentException("Value must be a non-negative integer.");
            }

            if (value == 0 || value == 1)
            {
                return 1;
            }

            return value * Factorial(value - 1);
        }

    }
}
