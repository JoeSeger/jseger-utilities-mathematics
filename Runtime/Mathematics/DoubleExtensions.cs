// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoubleExtensions.cs">
//   Copyright (c) 2023 Seger Services. All rights reserved.
//   Written by Joseph Seger <joseph@josephseger.com>
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace JSeger.Utilities.Mathematics
{
    /// <summary>
    /// Provides extension methods for System.Double to support various mathematical operations.
    /// </summary>
    public static class DoubleExtensions
    {
        public static double Add(this double number1, double number2) => GenericTools.Add(number1, number2);
        public static double Subtract(this double number1, double number2) => GenericTools.Subtract(number1, number2);
        public static double Multiply(this double number1, double number2) => GenericTools.Multiply(number1, number2);
        public static double Divide(this double number1, double number2) => GenericTools.Divide(number1, number2);
        
        public static double Modulo(this double number1, double number2) => GenericTools.Modulo(number1, number2);
        public static double Max(this double number1, double number2) => GenericTools.Max(number1, number2);
        public static double Min(this double number1, double number2) => GenericTools.Min(number1, number2);

        public static double Abs(this double number) => GenericTools.Abs(number);
        public static double Pow(this double number, double power) => GenericTools.Pow(number, power);
        public static double Sqrt(this double number) => GenericTools.Sqrt(number);

        public static bool IsGreaterThan(this double number1, double number2) => GenericTools.IsGreaterThan(number1, number2);
        public static bool IsLessThan(this double number1, double number2) => GenericTools.IsLessThan(number1, number2);
        public static bool IsGreaterThanOrEqualTo(this double number1, double number2) => GenericTools.IsGreaterThanOrEqualTo(number1, number2);
        public static bool IsLessThanOrEqualTo(this double number1, double number2) => GenericTools.IsLessThanOrEqualTo(number1, number2);

        public static bool IsEqualTo(this double number1, double number2) => GenericTools.IsEqualTo(number1, number2);

        public static bool AlmostEquals(this double number1, double number2, double tolerance = 0.0001f) =>
            GenericTools.AlmostEquals(number1, number2, tolerance);
        
        public static bool InRange(this double value, double min, double max) => GenericTools.InRange(value, min, max);
    }
}
