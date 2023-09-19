// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ULongExtensions.cs">
//   Copyright (c) 2023 Seger Services. All rights reserved.
//   Written by Joseph Seger <joseph@josephseger.com>
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace JSeger.Utilities.Mathematics
{
    /// <summary>
    /// Provides extension methods for ulong type to support various mathematical operations using GenericTools.
    /// </summary>
    public static class ULongExtensions
    {
        public static ulong Add(this ulong number1, ulong number2) => GenericTools.Add(number1, number2);

        public static ulong Subtract(this ulong number1, ulong number2) => GenericTools.Subtract(number1, number2);

        public static ulong Multiply(this ulong number1, ulong number2) => GenericTools.Multiply(number1, number2);

        public static ulong Divide(this ulong number1, ulong number2) => GenericTools.Divide(number1, number2);

        public static ulong Modulo(this ulong number1, ulong number2) => GenericTools.Modulo(number1, number2);

        public static ulong Max(this ulong number1, ulong number2) => GenericTools.Max(number1, number2);

        public static ulong Min(this ulong number1, ulong number2) => GenericTools.Min(number1, number2);

        public static ulong Abs(this ulong number) => GenericTools.Abs(number);

        public static ulong Pow(this ulong number, ulong power) => GenericTools.Pow(number, power);

        public static ulong Sqrt(this ulong number) => GenericTools.Sqrt(number);

        public static bool IsGreaterThan(this ulong number1, ulong number2) => GenericTools.IsGreaterThan(number1, number2);

        public static bool IsLessThan(this ulong number1, ulong number2) => GenericTools.IsLessThan(number1, number2);

        public static bool IsGreaterThanOrEqualTo(this ulong number1, ulong number2) => GenericTools.IsGreaterThanOrEqualTo(number1, number2);

        public static bool IsLessThanOrEqualTo(this ulong number1, ulong number2) => GenericTools.IsLessThanOrEqualTo(number1, number2);

        public static bool IsEqualTo(this ulong number1, ulong number2) => GenericTools.IsEqualTo(number1, number2);

        public static bool AlmostEquals(this ulong number1, ulong number2, ulong tolerance = 0) => GenericTools.AlmostEquals(number1, number2, tolerance);

        public static bool InRange(this ulong value, ulong min, ulong max) => GenericTools.InRange(value, min, max);
    }
}
