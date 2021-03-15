

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
        public static bool Equals(this Directions dir, Directions other)
        {
            return (dir & other) == other;
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
