// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Float3Extensions.cs">
//   Copyright (c) 2023 Seger Services. All rights reserved.
//   Written by Joseph Seger <joseph@josephseger.com>
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Unity.Mathematics;

namespace JSeger.Utilities.Mathematics
{
    /// <summary>
    /// Provides extension methods for Unity.Mathematics.float3 structure to support various mathematical and geometric operations.
    /// </summary>
    public static class Float3Extensions
    {
        public static float3 WithX(this float3 vector, float x) => new(x, vector.y, vector.z);
        public static float3 WithY(this float3 vector, float y) => new(vector.x, y, vector.z);
        public static float3 WithZ(this float3 vector, float z) => new(vector.x, vector.y, z);

        public static float3 Add(this float3 vector, float3 other) => MathExtensions.Add(vector, other);
        public static float3 AddX(this float3 vector, float x) => new(vector.x + x, vector.y, vector.z);
        public static float3 AddY(this float3 vector, float y) => new(vector.x, vector.y + y, vector.z);
        public static float3 AddZ(this float3 vector, float z) => new float3(vector.x, vector.y, vector.z + z);

        public static float Distance(this float3 vector, float3 other) => math.distance(vector, other);
        public static float3 Lerp(this float3 a, float3 b, float t) => math.lerp(a, b, t);

        public static float Length(this float3 vector) => math.length(vector);
        public static float3 Normalized(this float3 vector) => math.normalize(vector);

        public static float DistanceTo(this float3 vector, float3 target) => math.distance(vector, target);

        public static float AngleTo(this float3 vector, float3 target) => 
            math.degrees(math.acos(math.dot(math.normalize(vector), math.normalize(target))));

        public static float3 Snap(this float3 value, float increment)
        {
            return new float3(
                math.round(value.x / increment) * increment,
                math.round(value.y / increment) * increment,
                math.round(value.z / increment) * increment
            );
        }

        public static float3 Bounce(this float3 value, float bounceLimit)
        {
            return new float3(
                value.x.Bounce(bounceLimit),
                value.y.Bounce(bounceLimit),
                value.z.Bounce(bounceLimit)
            );
        }

        public static float Dot(this float3 vector, float3 target) => math.dot(vector, target);

        public static float3 Cross(this float3 vector, float3 target) => math.cross(vector, target);

        public static float3 Subtract(this float3 vector, float3 other) => MathExtensions.Subtract(vector, other);

        public static float3 Set(this float3 vector, float? x = null, float? y = null, float? z = null)
        {
            vector.x = x ?? vector.x;
            vector.y = y ?? vector.y;
            vector.z = z ?? vector.z;
            return vector;
        }
    }
}
