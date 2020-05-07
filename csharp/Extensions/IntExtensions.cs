using System;

namespace csharp.Extensions
{
    public static class IntExtensions
    {
        public static int Clamped(this int x, int min, int max)
        {
            int clampedValue = x;
            clampedValue = Math.Min(clampedValue, max);
            clampedValue = Math.Max(clampedValue, min);
            return clampedValue;
        }
    }
}