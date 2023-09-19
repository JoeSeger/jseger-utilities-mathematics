// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FloatExtensions.cs">
//   Copyright (c) 2023 Seger Services. All rights reserved.
//   Written by Joseph Seger <joseph@josephseger.com>
// </copyright>
// --------------------------------------------------------------------------------------------------------------------------------

using Unity.Mathematics;

namespace JSeger.Utilities.Mathematics
{
    /// <summary>
    /// Provides extension methods for floating-point numbers to support various mathematical operations.
    /// </summary>
    public static class FloatExtensions
    {
        public static float Add(this float number1, float number2) => GenericTools.Add(number1, number2);
        public static float Subtract(this float number1, float number2) => GenericTools.Subtract(number1, number2);
        public static float Multiply(this float number1, float number2) => GenericTools.Multiply(number1, number2);
        public static float Divide(this float number1, float number2) => GenericTools.Divide(number1, number2);
        public static float Bounce(this float value, float bounceLimit) => math.abs(math.sin(value)) * bounceLimit;
        public static float Modulo(this float number1, float number2) => GenericTools.Modulo(number1, number2);
        public static float Max(this float number1, float number2) => GenericTools.Max(number1, number2);
        public static float Min(this float number1, float number2) => GenericTools.Min(number1, number2);
        public static float Abs(this float number) => GenericTools.Abs(number);
        public static float Pow(this float number, float power) => GenericTools.Pow(number, power);
        public static float Sqrt(this float number) => GenericTools.Sqrt(number);

        public static float SmoothStep(float a, float b, float t)
        {
            t = math.clamp(t, 0.0f, 1.0f);
            return math.lerp(a, b, t * t * (3.0f - 2.0f * t));
        }

        public static bool IsGreaterThan(this float number1, float number2) => 
            GenericTools.IsGreaterThan(number1, number2);

        public static bool IsLessThan(this float number1, float number2) => 
            GenericTools.IsLessThan(number1, number2);

        public static bool IsGreaterThanOrEqualTo(this float number1, float number2) => 
            GenericTools.IsGreaterThanOrEqualTo(number1, number2);

        public static bool IsLessThanOrEqualTo(this float number1, float number2) => 
            GenericTools.IsLessThanOrEqualTo(number1, number2);

        public static bool IsEqualTo(this float number1, float number2) => 
            GenericTools.IsEqualTo(number1, number2);

        public static bool AlmostEquals(this float number1, float number2, float tolerance = 0.0001f) => 
            GenericTools.AlmostEquals(number1, number2, tolerance);

        public static bool InRange(this float value, float min, float max) => 
            GenericTools.InRange(value, min, max);
    }
}
