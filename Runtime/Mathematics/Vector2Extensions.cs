// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Vector2Extensions.cs">
//   Copyright (c) 2023 Seger Services. All rights reserved.
//   Written by Joseph Seger <joseph@josephseger.com>
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using UnityEngine;

namespace JSeger.Utilities.Mathematics
{
    /// <summary>
    /// Provides extension methods for the Vector2 type to support various mathematical and geometric operations.
    /// </summary>
    public static class Vector2Extensions
    {
        public static Vector2 WithX(this Vector2 vector, float x) => new(x, vector.y);
        public static Vector2 WithY(this Vector2 vector, float y) => new(vector.x, y);
   
        public static float Length(this Vector2 vector) => vector.magnitude;
        public static Vector2 Normalized(this Vector2 vector) => vector.normalized;
      
        public static Vector2 Add(this Vector2 vector, Vector2 other) => MathExtensions.Add(vector, other);
        public static Vector2 AddX(this Vector2 vector, float x) => new(vector.x + x, vector.y);
        public static Vector2 AddY(this Vector2 vector, float y) => new(vector.x, vector.y + y);
        
        public static Vector2 Subtract(this Vector2 vector, Vector2 other) => MathExtensions.Subtract(vector, other);
        
        public static bool InRange(this Vector2 vector, Vector2 min, Vector2 max) => 
            GenericTools.InRange(vector.x, min.x, max.x) && GenericTools.InRange(vector.y, min.y, max.y);
        
        public static Vector2 Rotate(this Vector2 vector, float angleDegrees)
        {
            var sin = Mathf.Sin(angleDegrees * Mathf.Deg2Rad);
            var cos = Mathf.Cos(angleDegrees * Mathf.Deg2Rad);

            var tx = vector.x;
            var ty = vector.y;
        
            return new Vector2(cos * tx - sin * ty, sin * tx + cos * ty);
        }
        public static float DistanceTo(this Vector2 vector, Vector2 target) => Vector2.Distance(vector, target);
        public static float AngleTo(this Vector2 vector, Vector2 target) => Vector2.Angle(vector, target);
        public static float Dot(this Vector2 vector, Vector2 target) => Vector2.Dot(vector, target);
    }
}
