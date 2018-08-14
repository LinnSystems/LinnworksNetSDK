namespace LinnworksMacroHelpers.Helpers
{
    public static class CodeHelper
    {
        public static bool Between(this int num, int lower, int upper, bool inclusive = false)
        {
            return inclusive ? lower <= num && num <= upper : lower < num && num < upper;
        }

        public static bool Between(this double num, double lower, double upper, bool inclusive = false)
        {
            if (double.IsNaN(num) || double.IsInfinity(num) || double.IsNegativeInfinity(num) || double.IsPositiveInfinity(num))
                return false;

            return inclusive ? lower <= num && num <= upper : lower < num && num < upper;
        }

        public static bool Between(this decimal num, decimal lower, decimal upper, bool inclusive = false)
        {
            return inclusive ? lower <= num && num <= upper : lower < num && num < upper;
        }

        public static int BetweenOrDefault(this int num, int lower, int upper, bool inclusive = false)
        {
            return num.Between(lower, upper, inclusive) ? num : default(int);
        }

        public static double BetweenOrDefault(this double num, double lower, double upper, bool inclusive = false)
        {
            return num.Between(lower, upper, inclusive) ? num : default(double);
        }

        public static decimal BetweenOrDefault(this decimal num, decimal lower, decimal upper, bool inclusive = false)
        {
            return num.Between(lower, upper, inclusive) ? num : default(decimal);
        }
    }
}