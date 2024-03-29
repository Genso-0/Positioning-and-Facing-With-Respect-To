﻿

namespace PositioningAndFacing
{
    public static class DirectionsHelper
    {
        public static void Add(ref this Directions dir, Directions other)
        {
            dir |= other;
        }
        public static void Remove(ref this Directions dir, Directions other)
        {
            dir &= ~other;
        }
        /// <summary>
        /// Finds if both enums are equal.
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static bool IsEqual(this Directions dir, Directions other)
        { 
            var temp1 = other;
            var temp2 = dir;
            temp1.Remove(dir);
            temp2.Remove(other);
            return (int)temp1 + (int)temp2 == 0;
        }
        /// <summary>
        /// Checks if an enumeration is part of a combination
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static bool Contains(this Directions dir, Directions other)
        {
            return (dir & other) != 0;
        }
        /// <summary>
        /// Finds the overlap between two combinations
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static Directions FindCommon(this Directions dir, Directions other)
        {
            return dir & other;
        }
    }
}
