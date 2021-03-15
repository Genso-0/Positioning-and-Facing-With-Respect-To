

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
        public static bool Equals(this Directions dir, Directions typeOfDirection)
        {
            switch (typeOfDirection)
            {
                case Directions.Up: return (dir & Directions.Up) == Directions.Up;
                case Directions.Down: return (dir & Directions.Down) == Directions.Down;
                case Directions.Forward: return (dir & Directions.Forward) == Directions.Forward;
                case Directions.Right: return (dir & Directions.Right) == Directions.Right;
                case Directions.Back: return (dir & Directions.Back) == Directions.Back;
                case Directions.Left: return (dir & Directions.Left) == Directions.Left;
                case Directions.ForwardRight: return (dir & Directions.Forward) == Directions.Forward && (dir & Directions.Right) == Directions.Right;
                case Directions.BackRight: return (dir & Directions.Back) == Directions.Back && (dir & Directions.Right) == Directions.Right;
                case Directions.BackLeft: return (dir & Directions.Back) == Directions.Back && (dir & Directions.Left) == Directions.Left;
                case Directions.ForwardLeft: return (dir & Directions.Forward) == Directions.Forward && (dir & Directions.Left) == Directions.Left ;
                case Directions.UpForward: return (dir & Directions.Up) == Directions.Up && (dir & Directions.Forward) == Directions.Forward;
                case Directions.UpForwardRight: return (dir & Directions.Up) == Directions.Up && (dir & Directions.Forward) == Directions.Forward && (dir & Directions.Right) == Directions.Right;
                case Directions.UpRight: return (dir & Directions.Up) == Directions.Up && (dir & Directions.Right) == Directions.Right;
                case Directions.UpBackRight: return (dir & Directions.Up) == Directions.Up && (dir & Directions.Back) == Directions.Back && (dir & Directions.Right) == Directions.Right;
                case Directions.UpBack: return (dir & Directions.Up) == Directions.Up && (dir & Directions.Back) == Directions.Back;
                case Directions.UpBackLeft: return (dir & Directions.Up) == Directions.Up && (dir & Directions.Back) == Directions.Back && (dir & Directions.Left) == Directions.Left;
                case Directions.UpLeft: return (dir & Directions.Up) == Directions.Up && (dir & Directions.Left) == Directions.Left;
                case Directions.UpForwardLeft: return (dir & Directions.Up) == Directions.Up && (dir & Directions.Forward) == Directions.Forward && (dir & Directions.Left) == Directions.Left;
                case Directions.DownForward: return (dir & Directions.Down) == Directions.Down && (dir & Directions.Forward) == Directions.Forward;
                case Directions.DownForwardRight: return (dir & Directions.Down) == Directions.Down && (dir & Directions.Forward) == Directions.Forward && (dir & Directions.Right) == Directions.Right;
                case Directions.DownRight: return (dir & Directions.Down) == Directions.Down && (dir & Directions.Right) == Directions.Right;
                case Directions.DownBackRight: return (dir & Directions.Down) == Directions.Down && (dir & Directions.Back) == Directions.Back && (dir & Directions.Right) == Directions.Right;
                case Directions.DownBack: return (dir & Directions.Down) == Directions.Down && (dir & Directions.Back) == Directions.Back;
                case Directions.DownBackLeft: return (dir & Directions.Down) == Directions.Down && (dir & Directions.Back) == Directions.Back && (dir & Directions.Left) == Directions.Left;
                case Directions.DownLeft: return (dir & Directions.Down) == Directions.Down && (dir & Directions.Left) == Directions.Left;
                case Directions.DownForwardLeft: return (dir & Directions.Down) == Directions.Down && (dir & Directions.Forward) == Directions.Forward && (dir & Directions.Left) == Directions.Left;
            }
            return false;
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
