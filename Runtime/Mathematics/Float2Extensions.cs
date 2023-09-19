// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Float2Extensions.cs">
//   Copyright (c) 2023 Seger Services. All rights reserved.
//   Written by Joseph Seger <joseph@josephseger.com>
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Unity.Mathematics;

namespace JSeger.Utilities.Mathematics
{
    /// <summary>
    /// Provides extension methods for Unity.Mathematics.float2 structure to support various mathematical and geometric operations.
    /// </summary>
    public static class Float2Extensions
    {
        public static float2 WithX(this float2 vector, float x) => new(x, vector.y);
        public static float2 WithY(this float2 vector, float y) => new(vector.x, y);
        public static float Length(this float2 vector) => math.length(vector);
        public static float2 Normalized(this float2 vector) => math.normalize(vector);

        public static float2 Rotate(this float2 vector, float angleDegrees)
        {
            var sin = math.sin(math.radians(angleDegrees));
            var cos = math.cos(math.radians(angleDegrees));
            var tx = vector.x;
            var ty = vector.y;
            return new float2(cos * tx - sin * ty, sin * tx + cos * ty);
        }

        public static float2 Snap(this float2 vector, float gridSize)
        {
            return new float2(
                math.round(vector.x / gridSize) * gridSize, 
                math.round(vector.y / gridSize) * gridSize);
        }

        public static float2 Bounce(this float2 vector, float2 normal, float damping = 0.8f) => 
            vector - 2 * math.dot(vector, normal) * normal * damping;

        public static float2 Add(this float2 vector, float2 other) => MathExtensions.Add(vector, other);
        public static float2 AddX(this float2 vector, float x) => new(vector.x + x, vector.y);
        public static float2 AddY(this float2 vector, float y) => new(vector.x, vector.y + y);
        public static float DistanceTo(this float2 vector, float2 target) => math.distance(vector, target);

        public static float AngleTo(this float2 vector, float2 target) => 
            math.degrees(math.acos(math.dot(math.normalize(vector), math.normalize(target))));

        public static float Dot(this float2 vector, float2 target) => math.dot(vector, target);
        public static float Distance(this float2 vector, float2 other) => math.distance(vector, other);

        public static float2 Subtract(this float2 vector, float2 other) => MathExtensions.Subtract(vector, other);

        public static float2 Set(this float2 vector, float? x = null, float? y = null, float? z = null)
        {
            vector.x = x ?? vector.x;
            vector.y = y ?? vector.y;
            return vector;
        }
    }
}
