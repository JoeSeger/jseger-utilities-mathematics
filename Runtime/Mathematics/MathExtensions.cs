// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MathExtensions.cs">
//   Copyright (c) 2023 Seger Services. All rights reserved.
//   Written by Joseph Seger <joseph@josephseger.com>
// </copyright>
// --------------------------------------------------------------------------------------------------------------------------------

using Unity.Mathematics;
using UnityEngine;

namespace JSeger.Utilities.Mathematics
{
    /// <summary>
    /// Provides extension methods to support various mathematical operations on different data types.
    /// </summary>
    public static class MathExtensions
    {
        // ULong extensions
        public static ulong Add(this ulong a, ulong b) => GenericTools.Add(a, b);
        public static ulong Subtract(this ulong a, ulong b) => GenericTools.Subtract(a, b);
        public static bool InRange(this ulong value, ulong min, ulong max) => GenericTools.InRange(value, min, max);

        // Byte extensions
        public static byte Add(this byte a, byte b) => GenericTools.Add(a, b);
        public static byte Subtract(this byte a, byte b) => GenericTools.Subtract(a, b);
        public static bool InRange(this byte value, byte min, byte max) => GenericTools.InRange(value, min, max);

        // Double extensions
        public static double Add(this double a, double b) => GenericTools.Add(a, b);
        public static double Subtract(this double a, double b) => GenericTools.Subtract(a, b);

        public static bool AlmostEquals(this double a, double b, double tolerance = 0.0001) =>
            math.abs(a - b) < tolerance;

        public static bool InRange(this double value, double min, double max) => GenericTools.InRange(value, min, max);

        // Decimal extensions
        public static decimal Add(this decimal a, decimal b) => GenericTools.Add(a, b);
        public static decimal Subtract(this decimal a, decimal b) => GenericTools.Subtract(a, b);

        public static bool InRange(this decimal value, decimal min, decimal max) =>
            GenericTools.InRange(value, min, max);

        // Short extensions
        public static short Add(this short a, short b) => GenericTools.Add(a, b);
        public static short Subtract(this short a, short b) => GenericTools.Subtract(a, b);
        public static bool InRange(this short value, short min, short max) => GenericTools.InRange(value, min, max);

        // UShort extensions
        public static ushort Add(this ushort a, ushort b) => GenericTools.Add(a, b);
        public static ushort Subtract(this ushort a, ushort b) => GenericTools.Subtract(a, b);
        public static bool InRange(this ushort value, ushort min, ushort max) => GenericTools.InRange(value, min, max);

        // Long extensions
        public static long Add(this long a, long b) => GenericTools.Add(a, b);
        public static long Subtract(this long a, long b) => GenericTools.Subtract(a, b);
        public static bool InRange(this long value, long min, long max) => GenericTools.InRange(value, min, max);

        // Unity.Mathematics float3 extensions
        public static float3 Add(float3 a, float3 b) => a + b;
        public static float3 Subtract(float3 a, float3 b) => a - b;

        // Unity Quaternion extensions
        public static Quaternion Add(Quaternion a, Quaternion b) => new(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);

        public static Quaternion Subtract(Quaternion a, Quaternion b) =>
            new(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);

        public static Quaternion Multiply(Quaternion a, Quaternion b) => a * b;

        // Unity.Mathematics quaternion extensions
        public static quaternion Add(quaternion a, quaternion b) => new(a.value + b.value);
        public static quaternion Subtract(quaternion a, quaternion b) => new(a.value - b.value);
        public static quaternion Multiply(quaternion a, quaternion b) => math.mul(a, b);

        // Unity Vector2 extensions
        public static Vector2 Add(Vector2 a, Vector2 b) => a + b;
        public static Vector2 Subtract(Vector2 a, Vector2 b) => a - b;

        // Unity Vector3 extensions
        public static Vector3 Add(Vector3 a, Vector3 b) => a + b;
        public static Vector3 Subtract(Vector3 a, Vector3 b) => a - b;

        // Unity.Mathematics float2 extensions
        public static float2 Add(float2 a, float2 b) => a + b;
        public static float2 Subtract(float2 a, float2 b) => a - b;
    }
}