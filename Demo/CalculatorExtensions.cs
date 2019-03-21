namespace Demo
{
    public static class CalculatorExtensions
    {
        public static int Add(this int a, int b)
        {
            return a + b;
        }

        public static double Add(this double a, double b)
        {
            return a + b;
        }

        public static decimal Add(this decimal a, decimal b)
        {
            return a + b;
        }

        public static int Subtract(this int a, int b)
        {
            return a - b;
        }

        public static double Subtract(this double a, double b)
        {
            return a - b;
        }

        public static decimal Subtract(this decimal a, decimal b)
        {
            // TEST SHOULD FAIL
            return a + b;
        }
        
        
        public static int Add2(this int a, int b)
        {
            return a + b;
        }
    }
}
