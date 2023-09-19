// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Vector3Extensions.cs">
//   Copyright (c) 2023 Seger Services. All rights reserved.
//   Written by Joseph Seger <joseph@josephseger.com>
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Unity.Mathematics;
using UnityEngine;

namespace JSeger.Utilities.Mathematics
{
    /// <summary>
    /// Provides extension methods for the Vector3 type to support various mathematical and geometric operations.
    /// </summary>
    public static class Vector3Extensions
    {
        public static Vector3 Add(this Vector3 vector, Vector3 other) => MathExtensions.Add(vector, other);
        public static Vector3 AddX(this Vector3 vector, float x) => new(vector.x + x, vector.y, vector.z);
        public static Vector3 AddY(this Vector3 vector, float y) => new(vector.x, vector.y + y, vector.z);
        public static Vector3 AddZ(this Vector3 vector, float z) => new(vector.x, vector.y, vector.z + z);

        public static Vector3 WithX(this Vector3 vector, float x) => new(x, vector.y, vector.z);
        public static Vector3 WithY(this Vector3 vector, float y) => new(vector.x, y, vector.z);
        public static Vector3 WithZ(this Vector3 vector, float z) => new(vector.x, vector.y, z);

        public static float Length(this Vector3 vector) => vector.magnitude;
        public static Vector3 Normalized(this Vector3 vector) => vector.normalized;

        public static Vector3 Subtract(this Vector3 vector, Vector3 other) => MathExtensions.Subtract(vector, other);

        public static Vector3 Bounce(this Vector3 vector, Vector3 normal, float damping = 0.8f) =>
            vector - 2 * Vector3.Dot(vector, normal) * normal * damping;

        public static Vector3 Snap(this Vector3 vector, float gridSize)
        {
            return new Vector3(
                math.round(vector.x / gridSize) * gridSize,
                math.round(vector.y / gridSize) * gridSize,
                math.round(vector.z / gridSize) * gridSize);
        }

        public static Vector3 Set(this Vector3 vector, float? x = null, float? y = null, float? z = null)
        {
            vector.x = x ?? vector.x;
            vector.y = y ?? vector.y;
            vector.z = z ?? vector.z;
            return vector;
        }

        public static bool InRange(this Vector3 vector, Vector3 min, Vector3 max) =>
            GenericTools.InRange(vector.x, min.x, max.x) &&
            GenericTools.InRange(vector.y, min.y, max.y) &&
            GenericTools.InRange(vector.z, min.z, max.z);

        public static float DistanceTo(this Vector3 vector, Vector3 target) => Vector3.Distance(vector, target);
        public static float AngleTo(this Vector3 vector, Vector3 target) => Vector3.Angle(vector, target);
        public static float Dot(this Vector3 vector, Vector3 target) => Vector3.Dot(vector, target);

        public static Vector3 Cross(this Vector3 vector, Vector3 target) => Vector3.Cross(vector, target);
    }
}