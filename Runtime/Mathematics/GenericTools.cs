// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenericTools.cs">
//   Copyright (c) 2023 Seger Services. All rights reserved.
//   Written by Joseph Seger <joseph@josephseger.com>
// </copyright>
// --------------------------------------------------------------------------------------------------------------------------------

using System;
using Unity.Mathematics;
using UnityEngine;

namespace JSeger.Utilities.Mathematics
{
    /// <summary>
    /// Provides a collection of generic mathematical tools for various data types.
    /// </summary>
    public static class GenericTools
    {
        #region Arithmetic Operations

        public static T Add<T>(T number1, T number2) => Operate(number1, number2, (a, b) => a + b);

        public static T Subtract<T>(T number1, T number2) => Operate(number1, number2, (a, b) => a - b);


        public static T Multiply<T>(T number1, T number2) => Operate(number1, number2, (a, b) => a * b);

        public static T Divide<T>(T number1, T number2) => Operate(number1, number2, (a, b) => a / b);

        public static T Modulo<T>(T number1, T number2) => Operate(number1, number2, (a, b) => a % b);


        public static T Max<T>(T number1, T number2)
        {
            var a = Convert.ToSingle(number1);
            var b = Convert.ToSingle(number2);
            return (T)(object)math.max(a, b);
        }

        public static T Min<T>(T number1, T number2)
        {
            var a = Convert.ToSingle(number1);
            var b = Convert.ToSingle(number2);
            return (T)(object)math.min(a, b);
        }

        public static T Abs<T>(T number)
        {
            var a = Convert.ToSingle(number);
            return (T)(object)math.abs(a);
        }

        public static T Pow<T>(T number, float power)
        {
            var a = Convert.ToSingle(number);
            return (T)(object)math.pow(a, power);
        }

        public static T Pow<T>(T number, double power)
        {
            var a = Convert.ToSingle(number);
            return (T)(object)math.pow(a, power);
        }

        public static T Sqrt<T>(T number)
        {
            var a = Convert.ToSingle(number);
            return (T)(object)math.sqrt(a);
        }

        #endregion

        #region Comparison Operations

        public static bool InRange<T>(T checkingValue, T minRange, T maxRange) =>
            IsGreaterThanOrEqualTo(checkingValue, minRange) && IsLessThanOrEqualTo(checkingValue, maxRange);


        public static bool IsGreaterThan<T>(T number1, T number2)
        {
            var a = Convert.ToSingle(number1);
            var b = Convert.ToSingle(number2);
            return a > b;
        }

        public static bool IsLessThan<T>(T number1, T number2)
        {
            var a = Convert.ToSingle(number1);
            var b = Convert.ToSingle(number2);
            return a < b;
        }

        public static bool IsGreaterThanOrEqualTo<T>(T number1, T number2)
        {
            var a = Convert.ToSingle(number1);
            var b = Convert.ToSingle(number2);
            return a >= b;
        }

        public static bool IsLessThanOrEqualTo<T>(T number1, T number2)
        {
            var a = Convert.ToSingle(number1);
            var b = Convert.ToSingle(number2);
            return a <= b;
        }

        public static bool IsEqualTo<T>(T number1, T number2) => number1.Equals(number2);


        public static bool AlmostEquals<T>(T number1, T number2, float tolerance = 0.0001f)
        {
            var a = Convert.ToSingle(number1);
            var b = Convert.ToSingle(number2);
            return math.abs(a - b) < tolerance;
        }

        public static bool AlmostEquals<T>(T number1, T number2, double tolerance = 0.0001f)
        {
            var a = Convert.ToSingle(number1);
            var b = Convert.ToSingle(number2);
            return math.abs(a - b) < tolerance;
        }

        /// <summary>
        /// Clamps the value between a minimum and maximum value.
        /// </summary>
        public static T Clamp<T>(T value, T min, T max)
        {
            var val = Convert.ToSingle(value);
            var minValue = Convert.ToSingle(min);
            var maxValue = Convert.ToSingle(max);
            return (T)(object)math.clamp(val, minValue, maxValue);
        }

        #endregion

        #region Utility Methods

        public static T Lerp<T>(T a, T b, float t)
        {
            if (typeof(T) == typeof(Vector3)) return (T)(object)Vector3.Lerp((Vector3)(object)a, (Vector3)(object)b, t);
            if (typeof(T) == typeof(Vector2)) return (T)(object)Vector2.Lerp((Vector2)(object)a, (Vector2)(object)b, t);
            if (typeof(T) == typeof(Quaternion))
                return (T)(object)Quaternion.Lerp((Quaternion)(object)a, (Quaternion)(object)b, t);
            if (typeof(T) == typeof(float)) return (T)(object)Mathf.Lerp((float)(object)a, (float)(object)b, t);
            if (typeof(T) == typeof(float3)) return (T)(object)math.lerp((float3)(object)a, (float3)(object)b, t);
            if (typeof(T) == typeof(float2)) return (T)(object)math.lerp((float2)(object)a, (float2)(object)b, t);
            if (typeof(T) == typeof(quaternion))
                return (T)(object)math.slerp((quaternion)(object)a, (quaternion)(object)b, t);

            throw new InvalidOperationException($"Lerp is not supported for type {typeof(T).Name}");
        }

        #endregion

        #region Private Helper Methods

        private static T Operate<T>(T number1, T number2, Func<float, float, float> operation)
        {
            var a = Convert.ToSingle(number1);
            var b = Convert.ToSingle(number2);

            return (T)(object)operation(a, b);
        }

        #endregion
    }
}