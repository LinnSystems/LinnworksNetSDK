using System;

namespace LinnworksMacroHelpers.Helpers
{
    public static class CodeHelper
    {
        public static bool Between(this Int32 num, Int32 lower, Int32 upper, Boolean inclusive = false)
        {
            return inclusive ? lower <= num && num <= upper : lower < num && num < upper;
        }

        public static bool Between(this Double num, Double lower, Double upper, Boolean inclusive = false)
        {
            if (Double.IsNaN(num) || Double.IsInfinity(num) || Double.IsNegativeInfinity(num) || Double.IsPositiveInfinity(num))
                return false;

            return inclusive ? lower <= num && num <= upper : lower < num && num < upper;
        }

        public static bool Between(this Decimal num, Decimal lower, Decimal upper, Boolean inclusive = false)
        {
            return inclusive ? lower <= num && num <= upper : lower < num && num < upper;
        }

        public static Int32 BetweenOrDefault(this Int32 num, Int32 lower, Int32 upper, Boolean inclusive = false)
        {
            return num.Between(lower, upper, inclusive) ? num : default(Int32);
        }

        public static Double BetweenOrDefault(this Double num, Double lower, Double upper, Boolean inclusive = false)
        {
            return num.Between(lower, upper, inclusive) ? num : default(Double);
        }

        public static Decimal BetweenOrDefault(this Decimal num, Decimal lower, Decimal upper, Boolean inclusive = false)
        {
            return num.Between(lower, upper, inclusive) ? num : default(Decimal);
        }
    }
}
