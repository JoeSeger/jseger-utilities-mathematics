// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ByteExtensions.cs">
//   Copyright (c) 2023 Seger Services. All rights reserved.
//   Written by Joseph Seger <joseph@josephseger.com>
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace JSeger.Utilities.Mathematics
{
    /// <summary>
    /// Provides extension methods for System.Byte to support various mathematical operations.
    /// </summary>
    public static class ByteExtensions
    {
        public static byte Add(this byte number1, byte number2) => GenericTools.Add(number1, number2);
        public static byte Subtract(this byte number1, byte number2) => GenericTools.Subtract(number1, number2);
        public static byte Multiply(this byte number1, byte number2) => GenericTools.Multiply(number1, number2);
        public static byte Divide(this byte number1, byte number2) => GenericTools.Divide(number1, number2);

        public static byte Modulo(this byte number1, byte number2) => GenericTools.Modulo(number1, number2);
        public static byte Max(this byte number1, byte number2) => GenericTools.Max(number1, number2);
        public static byte Min(this byte number1, byte number2) => GenericTools.Min(number1, number2);

        public static byte Abs(this byte number) => GenericTools.Abs(number);
        public static byte Pow(this byte number, byte power) => GenericTools.Pow(number, power);
        public static byte Sqrt(this byte number) => GenericTools.Sqrt(number);

        public static bool IsGreaterThan(this byte number1, byte number2) => GenericTools.IsGreaterThan(number1, number2);
        public static bool IsLessThan(this byte number1, byte number2) => GenericTools.IsLessThan(number1, number2);
        public static bool IsGreaterThanOrEqualTo(this byte number1, byte number2) => GenericTools.IsGreaterThanOrEqualTo(number1, number2);
        public static bool IsLessThanOrEqualTo(this byte number1, byte number2) => GenericTools.IsLessThanOrEqualTo(number1, number2);

        public static bool IsEqualTo(this byte number1, byte number2) => GenericTools.IsEqualTo(number1, number2);

        public static bool AlmostEquals(this byte number1, byte number2, byte tolerance = 0) =>
            GenericTools.AlmostEquals(number1, number2, tolerance);

        public static bool InRange(this byte value, byte min, byte max) => GenericTools.InRange(value, min, max);
    }
}
