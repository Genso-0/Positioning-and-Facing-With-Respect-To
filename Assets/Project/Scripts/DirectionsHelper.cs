

namespace RelativesLib
{
    public static class DirectionsHelper
    {
        public static void Add(ref this Directions dir, Directions directionToAdd)
        {
            dir |= directionToAdd;
        }
        public static void Remove(ref this Directions dir, Directions directionToRemove)
        {
            dir &= ~directionToRemove;
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
        public static bool Contains(this Directions dir, Directions typeOfDirection)
        {
            switch (typeOfDirection)
            { 
                case Directions.Up: return (dir & Directions.Up) == Directions.Up;
                case Directions.Down: return (dir & Directions.Down) == Directions.Down;
                case Directions.Forward: return (dir & Directions.Forward) == Directions.Forward;
                case Directions.Right: return (dir & Directions.Right) == Directions.Right;
                case Directions.Back: return (dir & Directions.Back) == Directions.Back;
                case Directions.Left: return (dir & Directions.Left) == Directions.Left;
                case Directions.ForwardRight: return (dir & Directions.ForwardRight) == Directions.ForwardRight;
                case Directions.BackRight: return (dir & Directions.BackRight) == Directions.BackRight;
                case Directions.BackLeft: return (dir & Directions.BackLeft) == Directions.BackLeft;
                case Directions.ForwardLeft: return (dir & Directions.ForwardLeft) == Directions.ForwardLeft;
                case Directions.UpForward: return (dir & Directions.UpForward) == Directions.UpForward;
                case Directions.UpForwardRight: return (dir & Directions.UpForwardRight) == Directions.UpForwardRight;
                case Directions.UpRight: return (dir & Directions.UpRight) == Directions.UpRight;
                case Directions.UpBackRight: return (dir & Directions.UpBackRight) == Directions.UpBackRight;
                case Directions.UpBack: return (dir & Directions.UpBack) == Directions.UpBack;
                case Directions.UpBackLeft: return (dir & Directions.UpBackLeft) == Directions.UpBackLeft;
                case Directions.UpLeft: return (dir & Directions.UpLeft) == Directions.UpLeft;
                case Directions.UpForwardLeft: return (dir & Directions.UpForwardLeft) == Directions.UpForwardLeft;
                case Directions.DownForward: return (dir & Directions.DownForward) == Directions.DownForward;
                case Directions.DownForwardRight: return (dir & Directions.DownForwardRight) == Directions.DownForwardRight;
                case Directions.DownRight: return (dir & Directions.DownRight) == Directions.DownRight;
                case Directions.DownBackRight: return (dir & Directions.DownBackRight) == Directions.DownBackRight;
                case Directions.DownBack: return (dir & Directions.DownBack) == Directions.DownBack;
                case Directions.DownBackLeft: return (dir & Directions.DownBackLeft) == Directions.DownBackLeft;
                case Directions.DownLeft: return (dir & Directions.DownLeft) == Directions.DownLeft;
                case Directions.DownForwardLeft: return (dir & Directions.DownForwardLeft) == Directions.DownForwardLeft;
            }
            return false;
        }
    }
}
