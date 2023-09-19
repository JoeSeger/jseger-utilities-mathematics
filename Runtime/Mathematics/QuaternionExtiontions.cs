// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuaternionExtensions.cs">
//   Copyright (c) 2023 Seger Services. All rights reserved.
//   Written by Joseph Seger <joseph@josephseger.com>
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Unity.Mathematics;
using UnityEngine;

namespace JSeger.Utilities.Mathematics
{
    /// <summary>
    /// Provides extension methods for Unity and Unity Mathematics quaternions to support various mathematical operations.
    /// </summary>
    public static class QuaternionExtensions
    {
        // For Unity's Quaternion
        public static Quaternion Euler(float3 newValue) => Quaternion.Euler(newValue);
        public static Quaternion Euler(float4 newValue) => new(newValue.x, newValue.y, newValue.z, newValue.w);

        public static Quaternion Set(this Quaternion quaternion, float? x = null, float? y = null, float? z = null, float? w = null)
        {
            quaternion.x = x ?? quaternion.x;
            quaternion.y = y ?? quaternion.y;
            quaternion.z = z ?? quaternion.z;
            quaternion.w = w ?? quaternion.w;

            return quaternion;
        }

        // Method to add a quaternion to another
        public static Quaternion Add(this Quaternion quaternion, Quaternion other) => MathExtensions.Add(quaternion, other);
        public static Quaternion AddX(this Quaternion quaternion, float x) => new(quaternion.x + x, quaternion.y, quaternion.z, quaternion.w);
        public static Quaternion AddY(this Quaternion quaternion, float y) => new(quaternion.x, quaternion.y + y, quaternion.z, quaternion.w);
        public static Quaternion AddZ(this Quaternion quaternion, float z) => new(quaternion.x, quaternion.y, quaternion.z + z, quaternion.w);
        public static Quaternion AddW(this Quaternion quaternion, float w) => new(quaternion.x, quaternion.y, quaternion.z, quaternion.w + w);

        // Method to subtract a quaternion from another
        public static Quaternion Subtract(this Quaternion quaternion, Quaternion other) => MathExtensions.Subtract(quaternion, other);

        // Method to add eulerAngles to a quaternion
        public static Quaternion AddEulerAngles(this Quaternion quaternion, Vector3 eulerAngles) => Quaternion.Euler(MathExtensions.Add(quaternion.eulerAngles, eulerAngles));

        // Method to get the angle between two quaternions
        public static float AngleBetween(this Quaternion a, Quaternion b) => Quaternion.Angle(a, b);

        // Method to spherically interpolate between two quaternions
        public static Quaternion SlerpTo(this Quaternion from, Quaternion to, float t)
        {
            t = GenericTools.Clamp(t, 0f, 1f);
            return Quaternion.Slerp(from, to, t);
        }

        // Method to interpolate between two quaternions
        public static Quaternion LerpTo(this Quaternion from, Quaternion to, float t)
        {
            t = GenericTools.Clamp(t, 0f, 1f);
            return Quaternion.Lerp(from, to, t);
        }

        // Method to create a quaternion from a Vector3 of euler angles
        public static Quaternion FromEuler(this Quaternion quaternion, Vector3 euler) => Quaternion.Euler(euler);

        // For Unity Mathematics' quaternion
        public static quaternion Set(this quaternion quaternion, float? x = null, float? y = null, float? z = null, float? w = null)
        {
            quaternion.value.x = x ?? quaternion.value.x;
            quaternion.value.y = y ?? quaternion.value.y;
            quaternion.value.z = z ?? quaternion.value.z;
            quaternion.value.w = w ?? quaternion.value.w;

            return quaternion;
        }

        // Method to add eulerAngles (as float3) to a quaternion
        public static quaternion AddEulerAngles(this quaternion quaternion, float3 eulerAngles) => math.mul(quaternion, quaternion.Euler(math.radians(eulerAngles)));

        // Method to add a quaternion to another
        public static quaternion Add(this quaternion quaternion, quaternion other) => MathExtensions.Add(quaternion, other);

        public static quaternion AddX(this quaternion quaternion, float x) => new(quaternion.value.x + x, quaternion.value.y, quaternion.value.z, quaternion.value.w);
        public static quaternion AddY(this quaternion quaternion, float y) => new(quaternion.value.x, quaternion.value.y + y, quaternion.value.z, quaternion.value.w);
        public static quaternion AddZ(this quaternion quaternion, float z) => new(quaternion.value.x, quaternion.value.y, quaternion.value.z + z, quaternion.value.w);
        public static quaternion AddW(this quaternion quaternion, float w) => new(quaternion.value.x, quaternion.value.y, quaternion.value.z, quaternion.value.w + w);

        // Method to subtract a quaternion from another
        public static quaternion Subtract(this quaternion quaternion, quaternion other) => MathExtensions.Subtract(quaternion, other);

        // Method to multiply a quaternion by another
        public static quaternion Multiply(this quaternion quaternion, quaternion other) => MathExtensions.Multiply(quaternion, other);
    }
}
