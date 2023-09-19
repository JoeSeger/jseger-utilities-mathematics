// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IntExtensions.cs">
//   Copyright (c) 2023 Seger Services. All rights reserved.
//   Written by Joseph Seger <joseph@josephseger.com>
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace JSeger.Utilities.Mathematics
{
    /// <summary>
    /// Provides extension methods for System.Int32 to support various mathematical operations.
    /// </summary>
    public static class IntExtensions
    {
        public static int Add(this int number1, int number2) => GenericTools.Add(number1, number2);
        public static int Subtract(this int number1, int number2) => GenericTools.Subtract(number1, number2);
        public static int Multiply(this int number1, int number2) => GenericTools.Multiply(number1, number2);
        public static int Divide(this int number1, int number2) => GenericTools.Divide(number1, number2);

        public static int Modulo(this int number1, int number2) => GenericTools.Modulo(number1, number2);
        public static int Max(this int number1, int number2) => GenericTools.Max(number1, number2);
        public static int Min(this int number1, int number2) => GenericTools.Min(number1, number2);

        public static int Abs(this int number) => GenericTools.Abs(number);
        public static int Pow(this int number, int power) => GenericTools.Pow(number, power);
        public static int Sqrt(this int number) => GenericTools.Sqrt(number);

        public static bool IsGreaterThan(this int number1, int number2) => GenericTools.IsGreaterThan(number1, number2);
        public static bool IsLessThan(this int number1, int number2) => GenericTools.IsLessThan(number1, number2);
        public static bool IsGreaterThanOrEqualTo(this int number1, int number2) => GenericTools.IsGreaterThanOrEqualTo(number1, number2);
        public static bool IsLessThanOrEqualTo(this int number1, int number2) => GenericTools.IsLessThanOrEqualTo(number1, number2);

        public static bool IsEqualTo(this int number1, int number2) => GenericTools.IsEqualTo(number1, number2);

        public static bool AlmostEquals(this int number1, int number2, int tolerance = 0) =>
            GenericTools.AlmostEquals(number1, number2, tolerance);

        public static bool InRange(this int value, int min, int max) => GenericTools.InRange(value, min, max);
    }
}
